namespace Interface_Segregation.Interfaces
{
    internal interface IShape
    {
        void DrawCircle();
        void DrawRectangular();
        void DrawTriangle();
    }
}

// INTERFACE-SEGREGATION PRINCIPLE
// INTERFACES AND CLASSES SHOULDN'T CONTAIN ANY METHODS THEY DON'T NEED