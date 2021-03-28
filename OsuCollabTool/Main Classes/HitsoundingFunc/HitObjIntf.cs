using NAudio.Wave;
using OsuCollabTool.CoreClasses;
using OsuCollabTool.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuCollabTool.Main_Classes.HitsoundingFunc
{
    public partial class HitObjIntf : Form
    {
        private string dir = String.Empty;

        public HitObjIntf()
        {
            InitializeComponent();

            UIDataExtractor ext = new UIDataExtractor();
            string[] files = Directory.GetFiles($@"{ext.getSongFol()}{ext.getCurrFol()}");

            // theme
            Color[] theme = ext.getTheme();
            Common.setBGCol(theme[2], BG1, BG2);
            Common.setBtnCol(theme[1], ChangeHS);
            Common.ContrastColor(theme[1], ChangeHS);
            Common.ContrastColor(theme[2], SelectSamplesetBox, Selector, changeWhistle, changeFinish, changeClap, Option1, Option2, Option3, ChangesBox, changeHitCircles, changeSpinners, changeSliderEnds, changeSliderHeads, SelectTimestampBox, MaxDurStart, MaxDurUntil, UntilTb, SelectFromTb, l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15);
            dir = $@"{ext.getSongFol()}{ext.getCurrFol()}\{ext.getCurrOsu()}";
            string audioDir = String.Empty;

            foreach (string file in files)
            {
                if (file.Contains(".mp3"))
                {
                    audioDir = $@"{ext.getSongFol()}{ext.getCurrFol()}\{Path.GetFileName(file)}";
                }
            }

            AudioFileReader duration = new AudioFileReader(audioDir);
            TimeSpan durationInt = duration.TotalTime;
            int totalTime = (int)durationInt.TotalMilliseconds;

            int minutes = totalTime / 1000 / 60;
            int minMili = minutes * 1000 * 60;
            int seconds = (totalTime - minMili) / 1000;
            int secMili = seconds * 1000;
            int miliseconds = totalTime - minMili - secMili;

            MaxDurStart.Text = $"{minutes}:{seconds}:{miliseconds}";
            MaxDurUntil.Text = $"{minutes}:{seconds}:{miliseconds}";

            StartTrackBar.Maximum = totalTime;
            UntilTrackBar.Maximum = totalTime;

            StartTrackBar.TickFrequency = 60 * 1000;
            UntilTrackBar.TickFrequency = 60 * 1000;

            StartTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, StartTrackBar));
            UntilTrackBar.Scroll += new EventHandler((sender, e) => TrackBar_TrackVal(sender, e, UntilTrackBar));

            string[] samplesetTypes = new string[] { "Auto", "Normal", "Soft", "Drum" };
            sampleSetCombo.Items.AddRange(samplesetTypes);
            additionalCombo.Items.AddRange(samplesetTypes);
            selectSampleset.Items.AddRange(samplesetTypes);
            selectAdditional.Items.AddRange(samplesetTypes);
            SelectSamplesetBox.Enabled = false;
            SelectTimestampBox.Enabled = false;
        }

        private void TrackBar_TrackVal(object sender, EventArgs e, TrackBar track)
        {
            int[] currVal = GetCurrTime(track.Value);
            trackNum.SetToolTip(track, $"{currVal[0]}:{currVal[1]}:{currVal[2]}");
            if (track == StartTrackBar)
            {
                SelectFromTb.Text = track.Value.ToString();
            }
            else if (track == UntilTrackBar)
            {
                UntilTb.Text = track.Value.ToString();
            }
        }

        private int[] GetCurrTime(int currMiliseconds)
        {
            int[] arr = new int[3];

            arr[0] = currMiliseconds / 1000 / 60;
            int minMili = arr[0] * 1000 * 60;
            arr[1] = (currMiliseconds - minMili) / 1000;
            int secMili = arr[1] * 1000;
            arr[2] = currMiliseconds - minMili - secMili;

            return arr;
        }

        private void ContentChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Name == "SelectFromTb")
                {
                    SelectFromTb.Text = ConvertToFormattedOffset(SelectFromTb.Text).ToString();

                    StartTrackBar.Value = Convert.ToInt32(SelectFromTb.Text);
                }
                else if ((sender as TextBox).Name == "UntilTb")
                {
                    UntilTb.Text = ConvertToFormattedOffset(UntilTb.Text).ToString();

                    UntilTrackBar.Value = Convert.ToInt32(UntilTb.Text);
                }
            }
            catch
            {
            }
        }

        private int ConvertToFormattedOffset(string input)
        {
            string offsetText = input;

            int offset = 0;

            if (offsetText.Contains(":"))
            {
                string[] arrOffset = offsetText.Split(':');

                int decimalNum = Convert.ToInt32(arrOffset[2]);

                int secondsNum = Convert.ToInt32(arrOffset[1]) * 1000;

                int minutesNum = Convert.ToInt32(arrOffset[0]) * 60 * 1000;

                offset = decimalNum + secondsNum + minutesNum;
            }
            else
            {
                offset = Convert.ToInt32(input);
            }

            return offset;
        }

        private void BaseSelect(object sender, EventArgs e)
        {
            switch ((sender as CheckBox).Name)
            {
                case "Option1":

                    if ((sender as CheckBox).Checked)
                    {
                        Option2.Checked = false;
                        Option3.Checked = false;
                        SelectSamplesetBox.Enabled = false;
                        SelectTimestampBox.Enabled = false;
                    }

                    break;

                case "Option2":
                    if ((sender as CheckBox).Checked)
                    {
                        Option1.Checked = false;
                        SelectSamplesetBox.Enabled = true;
                    }
                    else
                    {
                        SelectSamplesetBox.Enabled = false;
                    }

                    break;

                case "Option3":
                    if ((sender as CheckBox).Checked)
                    {
                        Option1.Checked = false;
                        SelectTimestampBox.Enabled = true;
                    }
                    else
                    {
                        SelectTimestampBox.Enabled = false;
                    }

                    break;
            }
        }

        private int hitsound = 0;
        private int normalSet = 0;
        private int additionalSet = 0;

        private async void ChangeHS_Click(object sender, EventArgs e)
        {
            hitsound = 0;
            normalSet = 0;
            additionalSet = 0;
            if (SelectTimestampBox.Enabled && (SelectFromTb.Text == String.Empty || UntilTb.Text == String.Empty))
            {
                MessageBox.Show(ExceptionsHandling.invalidInput.Message);
            }
            else if (SelectTimestampBox.Enabled && (Convert.ToInt32(SelectFromTb.Text) > Convert.ToInt32(UntilTb.Text)))
            {
                MessageBox.Show(ExceptionsHandling.invalidInput.Message);
            }
            else
            {
                ChangeHS.Text = "Processing...";

                if (changeWhistle.Checked)
                {
                    hitsound = hitsound + BitFlag(1);
                }
                if (changeFinish.Checked)
                {
                    hitsound = hitsound + BitFlag(2);
                }
                if (changeClap.Checked)
                {
                    hitsound = hitsound + BitFlag(3);
                }

                switch (sampleSetCombo.SelectedItem.ToString())
                {
                    case "Auto":
                        normalSet = 0;
                        break;

                    case "Normal":
                        normalSet = 1;
                        break;

                    case "Soft":
                        normalSet = 2;
                        break;

                    case "Drum":
                        normalSet = 3;
                        break;
                }
                switch (additionalCombo.SelectedItem.ToString())
                {
                    case "Auto":
                        additionalSet = 0;
                        break;

                    case "Normal":
                        additionalSet = 1;
                        break;

                    case "Soft":
                        additionalSet = 2;
                        break;

                    case "Drum":
                        additionalSet = 3;
                        break;
                }

                Exception exc = new Exception();

                if (Option1.Checked)
                {
                    exc = await Task.Run(ChangeAll);//ChangeAll();//
                }
                else if (Option2.Checked && Option3.Checked)
                {
                    publicSelectSampleset = selectSampleset.SelectedItem.ToString();
                    publicSelectAdditional = selectAdditional.SelectedItem.ToString();
                    exc = await Task.Run(ChangeConditionBoth);
                }
                else if (Option2.Checked)
                {
                    exc = await Task.Run(ChangeCondition2);
                }
                else if (Option3.Checked)
                {
                    exc = await Task.Run(ChangeCondition3);
                }

                if (exc == null)
                {
                    ChangeHS.Text = "Complete!";
                    MessageBox.Show("Edits have been completed successfully!");

                    ChangeHS.Text = "Make Changes!";
                }
                else
                {
                    ChangeHS.Text = "Error";
                    MessageBox.Show(exc.Message);
                    ChangeHS.Text = "Make Changes!";
                }
            }
        }

        private string publicSelectSampleset = "";
        private string publicSelectAdditional = "";

        private Exception ChangeAll()
        {
            Exception exc = null;
            MapDataExtractor map = new MapDataExtractor(dir);
            List<string> hitObjects = map.GetHitObjString();
            hitObjects.RemoveAt(0);

            Queue<string> hitCircles = new Queue<string>();
            Queue<string> sliders = new Queue<string>();
            Queue<string> spinners = new Queue<string>();
            List<string> result = new List<string>();

            result.Add("[HitObjects]");

            if (changeHitCircles.Checked)
            {
                List<string> temp = GetHitCircles(hitObjects);
                hitCircles = ChangeHitCircle(temp);
            }
            else
            {
                hitCircles = new Queue<string>(GetHitCircles(hitObjects));
            }
            if (changeSliderEnds.Checked || changeSliderHeads.Checked)
            {
                List<string> temp = GetSliders(hitObjects);
                sliders = ChangeSlider(temp);
            }
            else
            {
                sliders = new Queue<string>(GetSliders(hitObjects));
            }
            if (changeSpinners.Checked)
            {
                List<string> temp = GetSpinners(hitObjects);
                spinners = ChangeSpinner(temp);
            }
            else
            {
                spinners = new Queue<string>(GetSpinners(hitObjects));
            }

            for (int i = 0; i < hitObjects.Count; i = i + 1)
            {
                int toDequeue = FindMin(hitCircles, sliders, spinners);

                switch (toDequeue)
                {
                    case 0:
                        result.Add(hitCircles.Dequeue());
                        break;

                    case 1:
                        result.Add(sliders.Dequeue());
                        break;

                    case 2:
                        result.Add(spinners.Dequeue());
                        break;

                    case 3:
                        break;
                }
            }

            Common.ReplaceFileWithNewData(dir, 8, result);

            return exc;
        }

        private int FindMin(Queue<string> hitCircles, Queue<string> sliders, Queue<string> spinners)
        {
            int result = 0;
            if (hitCircles.Count == 0)
            {
                if (sliders.Count == 0)
                {
                    if (spinners.Count == 0)
                    {
                        result = 3;
                    }
                    else
                    {
                        result = 2;
                    }
                }
                else
                {
                    if (spinners.Count == 0)
                    {
                        result = 1;
                    }
                    else
                    {
                        if (Convert.ToInt32(sliders.Peek().Split(',')[2]) > Convert.ToInt32(spinners.Peek().Split(',')[2]))
                        {
                            result = 2;
                        }
                        else
                        {
                            result = 1;
                        }
                    }
                }
            }
            else
            {
                if (sliders.Count == 0)
                {
                    if (spinners.Count == 0)
                    {
                        result = 0;
                    }
                    else
                    {
                        if (Convert.ToInt32(hitCircles.Peek().Split(',')[2]) > Convert.ToInt32(spinners.Peek().Split(',')[2]))
                        {
                            result = 2;
                        }
                        else
                        {
                            result = 0;
                        }
                    }
                }
                else
                {
                    if (spinners.Count == 0)
                    {
                        if (Convert.ToInt32(hitCircles.Peek().Split(',')[2]) > Convert.ToInt32(sliders.Peek().Split(',')[2]))
                        {
                            result = 1;
                        }
                        else
                        {
                            result = 0;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(hitCircles.Peek().Split(',')[2]) > Convert.ToInt32(sliders.Peek().Split(',')[2]))
                        {
                            if (Convert.ToInt32(sliders.Peek().Split(',')[2]) > Convert.ToInt32(spinners.Peek().Split(',')[2]))
                            {
                                result = 2;
                            }
                            else
                            {
                                result = 1;
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(hitCircles.Peek().Split(',')[2]) > Convert.ToInt32(spinners.Peek().Split(',')[2]))
                            {
                                result = 2;
                            }
                            else
                            {
                                result = 0;
                            }
                        }
                    }
                }
            }
            return result;
        }

        private Exception ChangeConditionBoth()
        {
            Exception exc = null;

            MapDataExtractor map = new MapDataExtractor(dir);
            List<string> hitObjects = map.GetHitObjString();
            hitObjects.RemoveAt(0);

            Queue<string> hitCircles = new Queue<string>();
            Queue<string> sliders = new Queue<string>();
            Queue<string> spinners = new Queue<string>();
            List<string> result = new List<string>();

            int start = Convert.ToInt32(SelectFromTb.Text);
            int end = Convert.ToInt32(UntilTb.Text);

            int selectedHitsound = 0;
            int selectedNormalSet = 0;
            int selectedAdditionalSet = 0;

            if (selectWhistle.Checked)
            {
                selectedHitsound = selectedHitsound + BitFlag(1);
            }
            if (selectFinish.Checked)
            {
                selectedHitsound = selectedHitsound + BitFlag(2);
            }
            if (selectClap.Checked)
            {
                selectedHitsound = selectedHitsound + BitFlag(3);
            }

            switch (publicSelectSampleset)
            {
                case "Auto":
                    selectedNormalSet = 0;
                    break;

                case "Normal":
                    selectedNormalSet = 1;
                    break;

                case "Soft":
                    selectedNormalSet = 2;
                    break;

                case "Drum":
                    selectedNormalSet = 3;
                    break;
            }
            switch (publicSelectAdditional)
            {
                case "Auto":
                    selectedAdditionalSet = 0;
                    break;

                case "Normal":
                    selectedAdditionalSet = 1;
                    break;

                case "Soft":
                    selectedAdditionalSet = 2;
                    break;

                case "Drum":
                    selectedAdditionalSet = 3;
                    break;
            }

            Queue<string> unselected = new Queue<string>();
            List<string> selected = new List<string>();

            foreach (var line in hitObjects)
            {
                if (Convert.ToInt32(line.Split(',')[2]) <= start)
                {
                    unselected.Enqueue(line);
                }
                else if (Convert.ToInt32(line.Split(',')[2]) >= end)
                {
                    unselected.Enqueue(line);
                }
                else
                {
                    if (!CheckCondition(line, selectedHitsound, selectedNormalSet, selectedAdditionalSet))
                    {
                        unselected.Enqueue(line);
                    }
                    else
                    {
                        selected.Add(line);
                    }
                }
            }

            result.Add("[HitObjects]");

            if (changeHitCircles.Checked)
            {
                List<string> temp = GetHitCircles(selected);
                hitCircles = ChangeHitCircle(temp);
            }

            if (changeSliderEnds.Checked || changeSliderHeads.Checked)
            {
                List<string> temp = GetSliders(selected);
                sliders = ChangeSlider(temp);
            }

            if (changeSpinners.Checked)
            {
                List<string> temp = GetSpinners(selected);
                spinners = ChangeSpinner(temp);
            }

            Queue<string> tempQueue = new Queue<string>();
            int firstLoopVal = hitCircles.Count + sliders.Count + spinners.Count;
            int secondLoopVal = selected.Count + unselected.Count;

            for (int i = 0; i < firstLoopVal; i = i + 1)
            {
                int toDequeue = FindMin(hitCircles, sliders, spinners);

                switch (toDequeue)
                {
                    case 0:
                        tempQueue.Enqueue(hitCircles.Dequeue());
                        break;

                    case 1:
                        tempQueue.Enqueue(sliders.Dequeue());
                        break;

                    case 2:
                        tempQueue.Enqueue(spinners.Dequeue());
                        break;

                    case 3:
                        break;
                }
            }

            for (int i = 0; i < secondLoopVal; i = i + 1)
            {
                int toDequeue = FindMin(tempQueue, unselected, new Queue<string>());

                switch (toDequeue)
                {
                    case 0:
                        result.Add(tempQueue.Dequeue());
                        break;

                    case 1:
                        result.Add(unselected.Dequeue());
                        break;

                    case 2:

                        break;

                    case 3:
                        break;
                }
            }

            Common.ReplaceFileWithNewData(dir, 8, result);

            return exc;
        }

        private Exception ChangeCondition2()
        {
            Exception exc = null;

            MapDataExtractor map = new MapDataExtractor(dir);
            List<string> hitObjects = map.GetHitObjString();
            hitObjects.RemoveAt(0);

            Queue<string> hitCircles = new Queue<string>();
            Queue<string> sliders = new Queue<string>();
            Queue<string> spinners = new Queue<string>();
            List<string> result = new List<string>();

            int selectedHitsound = 0;
            int selectedNormalSet = 0;
            int selectedAdditionalSet = 0;

            if (selectWhistle.Checked)
            {
                selectedHitsound = selectedHitsound + BitFlag(1);
            }
            if (selectFinish.Checked)
            {
                selectedHitsound = selectedHitsound + BitFlag(2);
            }
            if (selectClap.Checked)
            {
                selectedHitsound = selectedHitsound + BitFlag(3);
            }

            switch (publicSelectSampleset)
            {
                case "Auto":
                    selectedNormalSet = 0;
                    break;

                case "Normal":
                    selectedNormalSet = 1;
                    break;

                case "Soft":
                    selectedNormalSet = 2;
                    break;

                case "Drum":
                    selectedNormalSet = 3;
                    break;
            }
            switch (publicSelectAdditional)
            {
                case "Auto":
                    selectedAdditionalSet = 0;
                    break;

                case "Normal":
                    selectedAdditionalSet = 1;
                    break;

                case "Soft":
                    selectedAdditionalSet = 2;
                    break;

                case "Drum":
                    selectedAdditionalSet = 3;
                    break;
            }

            Queue<string> unselected = new Queue<string>();
            List<string> selected = new List<string>();

            foreach (var line in hitObjects)
            {
                if (!CheckCondition(line, selectedHitsound, selectedNormalSet, selectedAdditionalSet))
                {
                    unselected.Enqueue(line);
                }
                else
                {
                    selected.Add(line);
                }
            }

            result.Add("[HitObjects]");

            if (changeHitCircles.Checked)
            {
                List<string> temp = GetHitCircles(selected);
                hitCircles = ChangeHitCircle(temp);
            }

            if (changeSliderEnds.Checked || changeSliderHeads.Checked)
            {
                List<string> temp = GetSliders(selected);
                sliders = ChangeSlider(temp);
            }

            if (changeSpinners.Checked)
            {
                List<string> temp = GetSpinners(selected);
                spinners = ChangeSpinner(temp);
            }

            Queue<string> tempQueue = new Queue<string>();
            int firstLoopVal = hitCircles.Count + sliders.Count + spinners.Count;
            int secondLoopVal = selected.Count + unselected.Count;

            for (int i = 0; i < firstLoopVal; i = i + 1)
            {
                int toDequeue = FindMin(hitCircles, sliders, spinners);

                switch (toDequeue)
                {
                    case 0:
                        tempQueue.Enqueue(hitCircles.Dequeue());
                        break;

                    case 1:
                        tempQueue.Enqueue(sliders.Dequeue());
                        break;

                    case 2:
                        tempQueue.Enqueue(spinners.Dequeue());
                        break;

                    case 3:
                        break;
                }
            }

            for (int i = 0; i < secondLoopVal; i = i + 1)
            {
                int toDequeue = FindMin(tempQueue, unselected, new Queue<string>());

                switch (toDequeue)
                {
                    case 0:
                        result.Add(tempQueue.Dequeue());
                        break;

                    case 1:
                        result.Add(unselected.Dequeue());
                        break;

                    case 2:

                        break;

                    case 3:
                        break;
                }
            }

            Common.ReplaceFileWithNewData(dir, 8, result);

            return exc;
        }

        private Exception ChangeCondition3()
        {
            Exception exc = null;

            MapDataExtractor map = new MapDataExtractor(dir);
            List<string> hitObjects = map.GetHitObjString();
            hitObjects.RemoveAt(0);

            Queue<string> hitCircles = new Queue<string>();
            Queue<string> sliders = new Queue<string>();
            Queue<string> spinners = new Queue<string>();
            List<string> result = new List<string>();


            int start = Convert.ToInt32(SelectFromTb.Text);
            int end = Convert.ToInt32(UntilTb.Text);


            Queue<string> unselected = new Queue<string>();
            List<string> selected = new List<string>();

            foreach (var line in hitObjects)
            {
                if (Convert.ToInt32(line.Split(',')[2]) <= start-1)
                {
                    unselected.Enqueue(line);
                }
                else if (Convert.ToInt32(line.Split(',')[2]) <= end+1)
                {
                    selected.Add(line);
                }
                else if (Convert.ToInt32(line.Split(',')[2]) >= end)
                {
                    unselected.Enqueue(line);
                }

            }

            result.Add("[HitObjects]");

            if (changeHitCircles.Checked)
            {
                List<string> temp = GetHitCircles(selected);
                hitCircles = ChangeHitCircle(temp);

            }

            if (changeSliderEnds.Checked || changeSliderHeads.Checked)
            {
                List<string> temp = GetSliders(selected);
                sliders = ChangeSlider(temp);
            }

            if (changeSpinners.Checked)
            {
                List<string> temp = GetSpinners(selected);
                spinners = ChangeSpinner(temp);
            }


            Queue<string> tempQueue = new Queue<string>();
            int firstLoopVal = hitCircles.Count + sliders.Count + spinners.Count;
            int secondLoopVal = selected.Count + unselected.Count;

            for (int i = 0; i < firstLoopVal; i = i + 1)
            {
                int toDequeue = FindMin(hitCircles, sliders, spinners);

                switch (toDequeue)
                {
                    case 0:
                        tempQueue.Enqueue(hitCircles.Dequeue());
                        break;
                    case 1:
                        tempQueue.Enqueue(sliders.Dequeue());
                        break;
                    case 2:
                        tempQueue.Enqueue(spinners.Dequeue());
                        break;
                    case 3:
                        break;
                }
            }

            for (int i = 0; i < secondLoopVal; i = i + 1)
            {
                int toDequeue = FindMin(tempQueue, unselected, new Queue<string>());

                switch (toDequeue)
                {
                    case 0:
                        result.Add(tempQueue.Dequeue());
                        break;
                    case 1:
                        result.Add(unselected.Dequeue());
                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                }
            }


            Common.ReplaceFileWithNewData(dir, 8, result);

            return exc;
        }

        private bool CheckCondition(string line, int hitsound, int sampleSet, int additional)
        {
            bool fulfilled = false;

            string[] split = line.Split(',');
            int bitNum = Convert.ToInt32(split[3]);
            string bin = Convert.ToString(bitNum, 2).PadLeft(8, '0');
            char[] charSplit = bin.Take(8).ToArray();
            if (charSplit[6] == '0' && charSplit[7] == '1') //if its a hit circle
            {
                string[] setSplit = split[5].Split(':');
                if (split[4] == $"{hitsound}" && split[5] == $"{sampleSet}:{additional}:{setSplit[2]}:{setSplit[3]}:{setSplit[4]}")
                {
                    fulfilled = true;
                }
            }
            else if (charSplit[6] == '1' && charSplit[7] == '0') // if its a slider
            {
                if (split.Length != 8)
                {
                    string[] hitsoundSplit = split[8].Split('|');
                    string[] setSplit = split[9].Split('|');
                    if ((split[8] == $"{hitsound}|{hitsoundSplit[1]}" || split[8] == $"{hitsoundSplit[0]}|{hitsound}")
                        && (split[9] == $"{sampleSet}:{additional}|{setSplit[1]}" || split[9] == $"{setSplit[0]}|{sampleSet}:{additional}"))
                    {
                        fulfilled = true;
                    }
                }
            }
            else if (charSplit[4] == '1' && charSplit[6] == '0' && charSplit[7] == '0') // if its a spinner
            {
                string[] setSplit = split[6].Split(':');
                if (split[4] == $"{hitsound}" && split[6] == $"{sampleSet}:{additional}:{setSplit[2]}:{setSplit[3]}:{setSplit[4]}")
                {
                    fulfilled = true;
                }
            }

            return fulfilled;
        }

        private int BitFlag(int num)
        {
            return Convert.ToInt32(Math.Pow(2, (double)num));
        }

        private Queue<string> ChangeHitCircle(List<string> hitCircles)
        {
            Queue<string> result = new Queue<string>();

            string valToInject = $"{hitsound},{normalSet}:{additionalSet}:0:0:";

            foreach (var line in hitCircles)
            {
                string[] split = line.Split(',');
                result.Enqueue($"{split[0]},{split[1]},{split[2]},{split[3]},{valToInject}");
            }

            return result;
        }

        private Queue<string> ChangeSlider(List<string> sliders)
        {
            Queue<string> result = new Queue<string>();

            foreach (var line in sliders)
            {
                string[] split = line.Split(',');

                if (changeSliderHeads.Checked && changeSliderEnds.Checked)
                {
                    if (split.Length == 8)
                    {
                        result.Enqueue($"{String.Join(",", split)}" +
                            $",{hitsound}|{hitsound},{normalSet}:{additionalSet}|" +
                            $"{normalSet}:{additionalSet},0:0:0:0:");
                    }
                    else
                    {
                        result.Enqueue($"{split[0]},{split[1]},{split[2]},{split[3]}," +
                            $"{split[4]},{split[5]},{split[6]},{split[7]},{hitsound}|" +
                            $"{hitsound},{normalSet}:{additionalSet}|{normalSet}:{additionalSet}," +
                            $"0:0:0:0:");
                    }
                }
                else if (changeSliderHeads.Checked)
                {
                    
                    if (split.Length == 8)
                    {
                        result.Enqueue($"{String.Join(",", split)},{hitsound}|0,{normalSet}:{additionalSet}|0:0,0:0:0:0:");
                    }
                    else
                    {
                        string[] hitsoundSplit = split[8].Split('|');
                        string[] setSplit = split[9].Split('|');
                        result.Enqueue($"{split[0]},{split[1]},{split[2]},{split[3]}," +
                            $"{split[4]},{split[5]},{split[6]},{split[7]},{hitsound}|" +
                            $"{hitsoundSplit[0]},{normalSet}:{additionalSet}|{setSplit[0]}," +
                            $"0:0:0:0:");
                    }
                }
                else if (changeSliderEnds.Checked)
                {
                    
                    if (split.Length == 8)
                    {
                        result.Enqueue($"{String.Join(",", split)},0|{hitsound},0:0|{normalSet}:{additionalSet},0:0:0:0:");
                    }
                    else
                    {

                        string[] hitsoundSplit = split[8].Split('|');
                        string[] setSplit = split[9].Split('|');
                        result.Enqueue($"{split[0]},{split[1]},{split[2]},{split[3]}," +
                            $"{split[4]},{split[5]},{split[6]},{split[7]},{hitsoundSplit[0]}|" +
                            $"{hitsound},{setSplit[0]}|{normalSet}:{additionalSet}," +
                            $"0:0:0:0:");
                    }
                }
            }

            return result;
        }

        private Queue<string> ChangeSpinner(List<string> spinners)
        {
            Queue<string> result = new Queue<string>();

            foreach (var line in spinners)
            {
                string[] split = line.Split(',');
                result.Enqueue($"{split[0]},{split[1]},{split[2]},{split[3]},{hitsound},{split[5]},{normalSet}:{additionalSet}:0:0:");
            }

            return result;
        }

        private List<string> GetHitCircles(List<string> hitObjects)
        {
            List<string> result = new List<string>();

            foreach (var line in hitObjects)
            {
                string[] split = line.Split(',');
                int bitNum = Convert.ToInt32(split[3]);
                string bin = Convert.ToString(bitNum, 2).PadLeft(8, '0');
                char[] charSplit = bin.Take(8).ToArray();
                if (charSplit[6] == '0' && charSplit[7] == '1')
                {
                    result.Add(line);
                }
            }

            return result;
        }

        private List<string> GetSliders(List<string> hitObjects)
        {
            List<string> result = new List<string>();

            foreach (var line in hitObjects)
            {
                string[] split = line.Split(',');
                int bitNum = Convert.ToInt32(split[3]);
                string bin = Convert.ToString(bitNum, 2).PadLeft(8, '0');
                char[] charSplit = bin.Take(8).ToArray();
                if (charSplit[6] == '1' && charSplit[7] == '0')
                {
                    result.Add(line);
                }
            }

            return result;
        }

        private List<string> GetSpinners(List<string> hitObjects)
        {
            List<string> result = new List<string>();

            foreach (var line in hitObjects)
            {
                string[] split = line.Split(',');
                int bitNum = Convert.ToInt32(split[3]);
                string bin = Convert.ToString(bitNum, 2).PadLeft(8, '0');
                char[] charSplit = bin.Take(8).ToArray();
                if (charSplit[4] == '1' && charSplit[6] == '0' && charSplit[7] == '0')
                {
                    result.Add(line);
                }
            }

            return result;
        }
    }
}