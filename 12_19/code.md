```C#
protected void Button1_Click(object sender, EventArgs e)
{
  int sum=0;
  int vol;
  foreach(GridViewRow i in GridView1.Rows)
  {
    if((TextBox) i.Cells[3].FindControl("TextBox1")).Text == "")
    {
      vol = 0;
    }else
    {
      vol = Int32.Parse(((TextBox) i.Cell[3].FindControl("TextBox1")).Text);
    }
    sum = sum + vol * Int32.Parse(i.Cell[2].Text);
  }
}
```
