//first statement
Potato potato;
if (potato != null)
{
    if (!potato.IsRotten && potato.HasBeenPeeled)
    {
        Cook(potato);
    }
}

//second statement
 bool shoudVisitCell = true;
 bool isYBetweemMinMax = minY <= y && y <= maxY;
 bool isXBetweenMinMax = minX <= x && x <= maxX;
 if (isXBetweenMinMax && (isYBetweemMinMax && shoudVisitCell))
 {
     VisitCell();
 }