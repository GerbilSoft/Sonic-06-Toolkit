﻿using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Marathon.IO;
using Newtonsoft.Json;
using JeremyAnsel.Media.WavefrontObj;
using Marathon.Helpers;

namespace Marathon.Formats.Mesh
{
    public class ReflectionArea
    {
        public float Z_Rotation { get; set; }

        public float Length { get; set; }

        public float Y_Rotation { get; set; }

        public float Height { get; set; }

        [JsonIgnore]
        public List<Vector3> Vertices { get; set; } = new();

        public ReflectionArea() { }

        public ReflectionArea(BinaryReaderEx reader)
        {
            Z_Rotation = reader.ReadSingle();
            Length     = reader.ReadSingle();
            Y_Rotation = reader.ReadSingle();
            Height     = reader.ReadSingle();
        }
    }

    /// <summary>
    /// <para>File base for the RAB format.</para>
    /// <para>Used in SONIC THE HEDGEHOG for reflection bounding boxes.</para>
    /// </summary>
    public class ReflectionZone : FileBase
    {
        public ReflectionZone() { }

        public ReflectionZone(string file, bool serialise = false)
        {
            switch (Path.GetExtension(file))
            {
                case ".json":
                {
                    Import(file);

                    // Save extension-less JSON (exploiting .NET weirdness, because it doesn't omit all extensions).
                    if (serialise)
                        Save(Path.GetFileNameWithoutExtension(file));

                    break;
                }

                default:
                {
                    Load(file);

                    if (serialise)
                        Export();

                    break;
                }
            }
        }

        public const string Extension = ".rab";

        public List<ReflectionArea> Reflections = new();

        public override void Load(Stream stream)
        {
            BINAReader reader = new(stream);

            uint reflectionTableCount  = reader.ReadUInt32(),
                 reflectionTableOffset = reader.ReadUInt32(),
                 entryTableCount       = reader.ReadUInt32(),
                 entryTableOffset      = reader.ReadUInt32();

            reader.JumpTo(reflectionTableOffset, true);

            for (int i = 0; i < reflectionTableCount; i++)
                Reflections.Add(new ReflectionArea(reader));

            reader.JumpTo(entryTableOffset, true);

            for (int i = 0; i < entryTableCount; i++)
            {
                uint vertexCount       = reader.ReadUInt32(),
                     vertexTableOffset = reader.ReadUInt32(),
                     reflectionIndex   = reader.ReadUInt32();

                long position = reader.BaseStream.Position;

                reader.JumpTo(vertexTableOffset, true);

                for (int v = 0; v < vertexCount; v++)
                    Reflections[(int)reflectionIndex].Vertices.Add(reader.ReadVector3());

                reader.JumpTo(position);
            }
        }

        public override void Save(Stream stream)
        {
            BINAWriter writer = new(stream);

            writer.Write(Reflections.Count);
            writer.AddOffset("reflectionTableOffset");

            writer.Write(Reflections.Count);
            writer.AddOffset("entryTableOffset");

            writer.FillOffset("reflectionTableOffset", true);
            for (int i = 0; i < Reflections.Count; i++)
            {
                writer.Write(Reflections[i].Z_Rotation);
                writer.Write(Reflections[i].Length);
                writer.Write(Reflections[i].Y_Rotation);
                writer.Write(Reflections[i].Height);
            }

            writer.FillOffset("entryTableOffset", true);
            for (int i = 0; i < Reflections.Count; i++)
            {
                writer.Write(Reflections[i].Vertices.Count);
                writer.AddOffset($"vertexTableOffset_{i}");
                writer.Write(i);
            }

            for (int i = 0; i < Reflections.Count; i++)
            {
                writer.FillOffset($"vertexTableOffset_{i}", true);

                foreach (Vector3 vector in Reflections[i].Vertices)
                    writer.Write(vector);
            }

            writer.FinishWrite();
        }

        public void Import(string json)
        {
            Reflections = JsonDeserialise<List<ReflectionArea>>(json);

            for (int i = 0; i < Reflections.Count; i++)
            {
                ObjFile obj = ObjFile.FromFile(StringHelper.ReplaceFilename(json, $"{Path.GetFileNameWithoutExtension(json)}.{i}.obj"));

                foreach (var vertex in obj.Vertices)
                    Reflections[i].Vertices.Add(new Vector3(vertex.Position.X, vertex.Position.Y, vertex.Position.Z));
            }
        }

        public void Export()
        {
            int currentRef = 0;
            
            foreach (var reflection in Reflections)
            {
                ObjFile obj = new()
                {
                    HeaderText = " This file is auto-generated by Marathon.\n" +                // haha reflect
                                 " If you wish to edit or remove a reflection area, ensure that you reflect these changes in the respective *.json file associated with this.\n"
                };

                foreach (var vertex in reflection.Vertices)
                    obj.Vertices.Add(new ObjVertex(vertex.X, vertex.Y, vertex.Z));

                obj.WriteTo($"{Path.GetFileNameWithoutExtension(Location)}.rab.{currentRef}.obj");

                currentRef++;
            }

            JsonSerialise(Reflections);
        }
    }
}