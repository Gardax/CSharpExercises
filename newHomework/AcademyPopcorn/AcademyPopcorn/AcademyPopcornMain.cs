using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 2;
            int startCol = 1;
            int endCol = WorldCols - 2;

            for (int i = startCol; i <= endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            Ball theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 200);
            //indestructable blocks
            for (int i = 1; i < WorldRows; i++)
            {
                //gameEngine.AddObject(new IndestructibleBlock(new MatrixCoords(i, 0)));
                //gameEngine.AddObject(new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1)));
                gameEngine.AddObject(new UnpassableBlock(new MatrixCoords(i, 0)));
                gameEngine.AddObject(new UnpassableBlock(new MatrixCoords(i, WorldCols - 1)));
            }
            for (int i = 0; i < WorldCols; i++)
            {
                //gameEngine.AddObject(new IndestructibleBlock(new MatrixCoords(1, i)));
                gameEngine.AddObject(new UnpassableBlock(new MatrixCoords(1, i)));
            }
            //end

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
