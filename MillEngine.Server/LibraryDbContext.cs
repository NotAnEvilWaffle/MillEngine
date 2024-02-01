using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MillEngine.Shared.Models.DTOs;

namespace MillEngine.API;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext() { }
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }
    
    public virtual DbSet<DeckEntry> LibraryDecks { get; set; }
    public virtual DbSet<CardEntry> LibraryCards { get; set; }
    public virtual DbSet<CollectionEntry> LibraryCollections { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        OnLibraryDecksCreate(builder);
        OnLibraryCollectionsCreate(builder);
    }

    protected void OnLibraryDecksCreate(ModelBuilder builder)
    {

        builder.Entity<DeckEntry>()
            .HasOne(x => x.Commander)
            .WithOne()
            .HasForeignKey<CardEntry>("DeckCommanderId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<DeckEntry>()
            .HasOne(x => x.Partner)
            .WithOne()
            .HasForeignKey<CardEntry>("DeckPartnerId")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        builder.Entity<DeckEntry>()
            .HasMany(x => x.DeckCards)
            .WithOne()
            .HasForeignKey("DeckMainId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<DeckEntry>()
            .HasMany(x => x.SideBoard)
            .WithOne()
            .HasForeignKey("DeckSideId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<DeckEntry>()
            .HasMany(x => x.MaybeList)
            .WithOne()
            .HasForeignKey("DeckMaybeId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<DeckEntry>()
            .HasMany(x => x.WishList)
            .WithOne()
            .HasForeignKey("DeckWishId")
            .OnDelete(DeleteBehavior.Cascade);
    }

    protected void OnLibraryCollectionsCreate(ModelBuilder builder)
    {
        builder.Entity<CollectionEntry>()
            .HasMany(x => x.CollectionCards)
            .WithOne()
            .HasForeignKey("CollectionId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}