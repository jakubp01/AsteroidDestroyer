using System.Collections.Generic;
using System.Windows.Forms;

namespace test
{
    internal class BulletsService
    {
        public BulletsService()
        {

        }
        public void BulletsMovment(Cartridge cartridge, CollisionDetectionService collisionDetectionService, List<Asteroid> asteroidsList, Player player, int skyBorder)
        {
            if (cartridge._CartridgeList.Count != 0)
            {

                for (int i = 0; i < cartridge._CartridgeList.Count; i++)
                {

                    var bullet = cartridge._CartridgeList[i];
                    collisionDetectionService.CollisonDetection(bullet);
                    if (collisionDetectionService._isAsteroidDelete)
                    {
                        asteroidsList.RemoveAt(collisionDetectionService._asteroidToDelete);
                        collisionDetectionService._isAsteroidDelete = false;
                        player._points += 4;
                    }
                    if (bullet.y > skyBorder)
                    {
                        BulletMove(bullet);
                    }
                    else
                    {
                        cartridge._CartridgeList.Remove(bullet);
                    }

                }

            }
        }

        void BulletMove(Bullet bullet)
        {
            bullet.y -= bullet._bulletSpeed;
            bullet._bulletSpeed += 3;
        }
        public void DrawingBullets(PaintEventArgs e, Cartridge cartridge)
        {
            foreach (var bullet in cartridge._CartridgeList)
            {
                bullet.Draw(e.Graphics);

            }
        }
    }
}
