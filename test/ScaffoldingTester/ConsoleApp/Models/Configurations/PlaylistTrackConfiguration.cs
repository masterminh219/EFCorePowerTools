﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace ConsoleApp.Models.Configurations
{
    public partial class PlaylistTrackConfiguration : IEntityTypeConfiguration<PlaylistTrack>
    {
        public void Configure(EntityTypeBuilder<PlaylistTrack> entity)
        {
            entity.HasKey(e => new { e.PlaylistId, e.TrackId })
                .IsClustered(false);

            entity.ToTable("PlaylistTrack");

            entity.HasIndex(e => e.TrackId, "IFK_PlaylistTrackTrackId");

            entity.HasOne(d => d.Playlist)
                .WithMany(p => p.PlaylistTracks)
                .HasForeignKey(d => d.PlaylistId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlaylistTrackPlaylistId");

            entity.HasOne(d => d.Track)
                .WithMany(p => p.PlaylistTracks)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlaylistTrackTrackId");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PlaylistTrack> entity);
    }
}
