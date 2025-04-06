using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard 
{
    string cardName { get; set; }
    int cardID { get; set; }
    bool isSelected { get; set; }
    bool isFound { get; set; }

}
