using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordamentSolver.Business.Interfaces;
using WordamentSolver.Business.Objects;
using System.Collections.Generic;

namespace WordamentSolver.Business.UnitTests
{
    [TestClass]
    public class TileTests
    {
        [TestMethod]
        public void Tile_GetAndSetLetter_LetterShouldMatch()
        {
            char firstTestLetter = 'X';
            char lowercaseTestLetter = 'b';
            Tile testTile = new Tile(firstTestLetter);
            Assert.AreEqual(firstTestLetter, testTile.Letter, "First test letter doesnt match");
            testTile.Letter = lowercaseTestLetter;
            Assert.AreEqual(lowercaseTestLetter, testTile.Letter, "Lowercase test letter doesn't match");
        }

        [TestMethod]
        public void Tile_SetConnectedTiles_AllTilesReturned()
        {

            // Setup
            Tile firstConnectedTile = new Tile('a');
            Tile secondConnectedTile = new Tile('b');
            Tile thirdConnectedTile = new Tile('c');
            List<ITile> connectedTileList = new List<ITile>();
            connectedTileList.Add(firstConnectedTile);
            connectedTileList.Add(thirdConnectedTile);
            connectedTileList.Add(secondConnectedTile);

            Tile testTile = new Tile();
            testTile.ConnectedTiles = connectedTileList;

            // Assertions
            Assert.AreEqual(3, testTile.ConnectedTiles.Count, "Connected tile list has incorrect number of tiles");
            CollectionAssert.Contains((List<ITile>)testTile.ConnectedTiles, firstConnectedTile, "Connected tile list does not contain first connected tile 'a'");
            CollectionAssert.Contains((List<ITile>)testTile.ConnectedTiles, secondConnectedTile, "Connected tile list does not contain second connected tile 'b'");
            CollectionAssert.Contains((List<ITile>)testTile.ConnectedTiles, thirdConnectedTile, "Connected tile list does not contain third connected tile 'c'");


        }
    }
}
