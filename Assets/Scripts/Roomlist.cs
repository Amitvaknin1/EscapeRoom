using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Roomlist : MonoBehaviour
{
    [SerializeField] Room[] rooms;
    public GUI button;
    
    public void OpenRoom(string roomName)
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i]._roomname == roomName)
            {
                rooms[i].Open();
            }
            else if (rooms[i].open)
            {
                CloseRoom(rooms[i]);
            }

        }
    }
    public void OpenRoom(Room room)
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i].open)
            {
                CloseRoom(rooms[i]);
            }
        }
        room.Open();
    }
    public void CloseRoom(Room menu)
    {
        menu.Close();
    }
}

