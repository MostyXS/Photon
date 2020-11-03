using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomListingsMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] Transform _content;
    [SerializeField] RoomListing _roomListing;



    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        for(int i = 0;i < roomList.Count;i++)
        {
            RoomInfo info = roomList[i];
            RoomListing listing = Instantiate(_roomListing, _content);
            if (listing)
                listing.SetRoomInfo(info);
        }

    }

}
