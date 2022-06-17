using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using TMPro;

public class LastGames : MonoBehaviour
{
    private int templateHeight = 60;

    private void Awake()
    {
        var entryContainer = transform.Find("EntryContainer");
        var entryTemplate = entryContainer.Find("EntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        var lastGames = GetLastGames();
        for(int i = 0; i < lastGames.Count; i++) {
            var recordRow = createRecordRow(entryContainer, entryTemplate, i);
            recordRow.Find("Name").GetComponent<TextMeshProUGUI>().text = lastGames[i].Name.ToString();
            recordRow.Find("HasWon").GetComponent<TextMeshProUGUI>().text = lastGames[i].HasWon.ToString();
            recordRow.Find("Time").GetComponent<TextMeshProUGUI>().text = lastGames[i].Time.ToString();
            recordRow.Find("GameTime").GetComponent<TextMeshProUGUI>().text = lastGames[i].GameTime.ToString();
        } 
    }

    private Transform createRecordRow(Transform container, Transform template, int index) 
    {
        var recordRow = Instantiate(template, container);
        var recordRowTransform = recordRow.GetComponent<RectTransform>();
        recordRowTransform.anchoredPosition = new Vector2(0, -templateHeight * index + 1);
        recordRowTransform.gameObject.SetActive(true);
        
        return recordRowTransform;
    }

    private List<GameEntry> GetLastGames() 
    {
        var lastGames = new List<GameEntry>();
        string filepath = Application.dataPath + "/user.db";
        
        string conn = "URI=file:" + filepath;
        IDbConnection dbconn = new SqliteConnection(conn);
        dbconn.Open();

        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = $"Select * from users ORDER BY Time desc LIMIT 8";
        dbcmd.CommandText = sqlQuery;
		var reader = dbcmd.ExecuteReader();
        while (reader.Read()) {

            lastGames.Add(
                new GameEntry()
                { 
                    Name = reader[1].ToString(),
                    HasWon = Int32.Parse(reader[2].ToString()) == 1 ? true : false,
                    GameTime = TimeSpan.FromMinutes(Double.Parse(reader[3].ToString())),
                    Time = DateTimeOffset.FromUnixTimeSeconds(Int64.Parse(reader[4].ToString())).DateTime
                });
        }
        dbconn.Close();

        return lastGames;
    }
}

public class GameEntry 
{
    public string Name { get; set; }

    public bool HasWon { get; set; }

    public TimeSpan GameTime { get; set; }

    public DateTime Time { get; set; }
}
