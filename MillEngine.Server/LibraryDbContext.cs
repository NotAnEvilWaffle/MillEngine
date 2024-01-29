using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MillEngine.Shared.Models.DTOs;

namespace MillEngine.API;

public class LibraryDbContext : DbContext
{
    public LibraryDbContext() { }
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }
    
    public virtual DbSet<DeckDTO> LibraryDecks { get; set; }
    public virtual DbSet<CardDTO> LibraryCards { get; set; }
    public virtual DbSet<CollectionDTO> LibraryCollections { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        
    }

    protected void OnLibraryDecksCreate(ModelBuilder builder)
    {

        builder.Entity<DeckDTO>()
            .HasOne(x => x.Commander)
            .WithOne()
            .HasForeignKey<CardDTO>("DeckCommanderId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<DeckDTO>()
            .HasOne(x => x.Partner)
            .WithOne()
            .HasForeignKey<CardDTO>("DeckPartnerId")
            .OnDelete(DeleteBehavior.Cascade);
        
        
        builder.Entity<DeckDTO>()
            .HasMany(x => x.DeckCards)
            .WithOne()
            .HasForeignKey("DeckMainId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<DeckDTO>()
            .HasMany(x => x.SideBoard)
            .WithOne()
            .HasForeignKey("DeckSideId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<DeckDTO>()
            .HasMany(x => x.MaybeList)
            .WithOne()
            .HasForeignKey("DeckMaybeId")
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<DeckDTO>()
            .HasMany(x => x.WishList)
            .WithOne()
            .HasForeignKey("DeckWishId")
            .OnDelete(DeleteBehavior.Cascade);
    }

    protected void OnLibraryCollectionsCreate(ModelBuilder builder)
    {
        builder.Entity<CollectionDTO>()
            .HasMany(x => x.CollectionCards)
            .WithOne()
            .HasForeignKey("CollectionId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}