using System;

class LightTorches
{
    static void Main()
    {
        int numberOfRooms = int.Parse(Console.ReadLine());
        string lightOrDark = Console.ReadLine();
        char[] roomsState = new char[numberOfRooms];
        
        // first part state of rooms
        for (int i = 0, j =0; i < roomsState.Length; i++, j++)
        {
            if (j == lightOrDark.Length)
            {
                j = 0;
            }
            roomsState[i] = lightOrDark[j];
            
        }

        // second part. Montitoring movements
        string[] command = Console.ReadLine().Split(' ');
        string direction = " ";
        int movement = 0;
        int centralRoom = (numberOfRooms / 2);
        int currentRoom = centralRoom;
        int lastRoom = -1;
      
        while(command[0] != "END")
        {
            direction = command[0];
            movement = int.Parse(command[1]);

            if(direction == "LEFT")
            {
                currentRoom -= (movement + 1);
                if(currentRoom < 0)
                {
                    currentRoom = 0;
                }              
            }
            else if(direction == "RIGHT")
            {
                currentRoom += (movement + 1);
                if(currentRoom > roomsState.Length - 1)
                {
                    currentRoom = roomsState.Length - 1;
                }
            }
            command = Console.ReadLine().Split(' ');

            if(currentRoom == lastRoom)
            {
                continue;
            }
            if(roomsState[currentRoom] == 'L')
            {
                roomsState[currentRoom] = 'D';
            }
            else
            {
                roomsState[currentRoom] = 'L';
            }

            lastRoom = currentRoom;
       
        }

        // third part. Counting the dark rooms and calculating the number of prayers

        int darkRooms = 0;
        for (int i = 0; i < roomsState.Length; i++)
        {
            if(roomsState[i] == 'D')
            {
                darkRooms++;
            }
        }

        int prayers = darkRooms * 68; // ASCII code of 'D'
        Console.WriteLine(prayers);
    }
}

