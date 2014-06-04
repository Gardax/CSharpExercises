bool found=false;
for (int index=0; index<100; index++)
{
	Console.WriteLine(array[index]);
	if (index%10==0)
	{
		if (array[index]==expectedValue)
		{
			found=true;
			break;
		}
	}
}

//More code here
if (found)
{
	Console.WriteLine("Value Found");
}