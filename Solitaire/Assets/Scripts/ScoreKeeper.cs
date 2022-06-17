using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;
using System;

public class ScoreKeeper : MonoBehaviour
{
    public Selectable[] topStacks;
    public GameObject highScorePanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HasWon())
        {
            Win();
        }
    }

    public bool HasWon()
    {
        int i = 0;
        foreach (Selectable topstack in topStacks)
        {
            i += topstack.value;
        }
        if (i >= 52)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    void Win()
    {
        highScorePanel.SetActive(true);
        print("You have won!");
        SaveGameScore(true);
    }

    private void SaveGameScore(bool hasWon) 
    {
        string filepath = Application.dataPath + "/user.db";
        string conn = "URI=file:" + filepath;
        IDbConnection dbconn = new SqliteConnection(conn);
        dbconn.Open();

        IDbCommand dbcmd = dbconn.CreateCommand();
        var userEntry = SetNameController.user;
        var hasWonEntry = hasWon ? 1 : 0;
        var gameTimeEntry = TimerController.instance.timePlaying.TotalSeconds;
        var timeEntry = DateTimeOffset.Now.ToUnixTimeSeconds();
        string insertCommand = $"Insert into users (name, hasWon, gameTime, time) VALUES ('{userEntry}', {hasWonEntry}, {gameTimeEntry}, {timeEntry})";
        dbcmd.CommandText = insertCommand;
		dbcmd.ExecuteNonQuery();
        dbconn.Close();
    }
}
