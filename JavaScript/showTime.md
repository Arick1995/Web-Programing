```html
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Document</title>
	<script type="text/JavaScript">
		function show(theform){
			var len = theform.bloodtype.length;
			for(var i = 0; i<sex_len; i++){
				if(theform.bloodtype[i].checked)
				{
					alert(theform.bloodtype[i].value);
				}
			}
		}

		function course_changed(theselect)
		{
			alert(theselect.value);
		}

		function interest_changed(theselect)
		{
			var ouput="";
			var id = theselect.selectedIndex;
			var introduce = theselect.value;

			output += "My Hobby is "+ theselect.options[id].text + "\n";
			output += introduce;
			alert(output);
		}

		function show_time(line){
			document.write(line + "<br>")
		}
		var time = new Date()
		show_time("Year:"+time.getFullYear())
		show_time("Month:" + time.getFullMonth())
		show_time("Date:"+ time.getDate())
		show_time("Day:" + time.getDay())
		show_time("Hours:" + time.getHours())
		show_time("Minutes:" + time.getMinutes())
		show_time("Seconds:" + time.getSeconds())
		show_time("TimeZone:" + time.getTimezoneOffset())
		show_time("Present Time:" + time.toLocaleString())
		show_time("Preset TimeZone:" + time.toGMTString())
	</script>
</head>
<body>
	<form name= "tademo">
		<br><br>

		Typing something here:
		<br>
		<input type="text" name="input" onChange="alert(this.value);this.select()">
		<br>
		<input type="button" value = "Click me to check" onClick = "alert(this.form.input.value)">

		<br><br>

		Bloodtype:
		<br>
		<input type="radio" name = "bloodtype" value="A">A<br>
		<input type="radio" name = "bloodtype" value="B">B<br>
		<input type="radio" name = "bloodtype" value="O">O<br>
		<input type="radio" name = "bloodtype" value="AB">AB<br>
		<input type="radio" name = "bloodtype" value="Other">Other<br>
		<input type="radio" name = "bloodtype" value="Unknown">I don't know...<br>
		<input type="button" onClick="show(this.form)" value ="Checking">
		<input type="button" onClick="this.form.bloodtype[5].click()" value = "I don't know...">

		<br><br>
		Something to say:
		<br>
		<select name="course" size = "1" onChange="course_changed(this)">
			<option selected value="Do you know something funny?">Tell me something</option>
			<option value="Tomato say "Catch Up"">Tell me a joke</option>
			<option value="HI">Hi</option>
		</select>
	</form>
	
</body>
</html>
```
