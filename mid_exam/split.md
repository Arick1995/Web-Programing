    ````c#
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        String[] words = TextBox1.Text.Split(',');
        ArrayList List = New ArrayList();
        foreach(String s in words){
        list.Add(Convert.ToInt32(s));
        }
        list.Sort();
