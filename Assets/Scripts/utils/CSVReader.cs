using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CSVReader
{
    private static CSVReader csv;
    private List<string[]> dataRecorder;

    private CSVReader() {
        dataRecorder = new List<string[]>();
    }

    public static CSVReader getInstance() {
        if (null != csv) {
            return csv;
        }
        return new CSVReader();
    }

    public void loadFile(string path, string fileName) {
        dataRecorder.Clear();
        StreamReader streamReader = null;
        try {
            streamReader = File.OpenText(path + "//" + fileName);
        } catch {
            Debug.Log("File " + fileName + " can not be found or opened");
            return;
        }
        string line;
        while ((line = streamReader.ReadLine()) != null) {
            dataRecorder.Add(line.Split(','));
        }
        streamReader.Close();
        streamReader.Dispose();
    } 

    public List<string[]> getData() {
        return this.dataRecorder;
    }
}
