<h1>Problem 1 &ndash; SoftUni Reception</h1>
<p>Every day thousands of students pass by the reception at SoftUni with different questions to ask and the employees have to help everyone by providing all the information and to answer all of the questions.</p>
<p>There are <strong>3 employees</strong> working on the reception all day. Each of them can handle <strong>different number</strong> <strong>of students</strong> <strong>per hour</strong>. Your task is to <strong>calculate how much time</strong> it will take to <strong>answer all the questions</strong> of given number of students.</p>
<p>First you will receive 3 lines with integers, representing <strong>count of students that each of the employee can </strong><strong>help per hour.</strong> On the next line you will receive <strong>students count as a single integer</strong>.</p>
<p><strong><u>Every forth</u> hour all of the employees have a break, so they don&rsquo;t work </strong><strong>for a hour.</strong> This is the only break for the employees, because they don`t need rest, nor have a personal life. Calculate the time needed to answer all the student's questions and print it in the following format: "Time needed: {time}h."</p>
<h2>Input / Constraints</h2>
<ul>
<li>On first three lines - <strong>each employee efficiency</strong> -&nbsp; integer in range <strong>[1 - 100]</strong></li>
<li>On the fourth line - <strong>students count</strong> &ndash; integer in range <strong>[0 &ndash; 10000]</strong></li>
<li>Input will always be valid and in the range specified</li>
</ul>
<h2>Output</h2>
<ul>
<li>Print a single line: "Time needed: {time}h."</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong></li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="326">
<p><strong>Input</strong></p>
</td>
<td width="384">
<p><strong>Output</strong></p>
</td>
<td width="764">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="326">
<p>5</p>
<p>6</p>
<p>4</p>
<p>20</p>
</td>
<td width="384">
<p>Time needed: 2h.</p>
</td>
<td width="764">
<p>All employees can answer 15 students per hour. After the first hour there are 5 students left to be answered.</p>
<p>All students will be answered in the second hour.</p>
</td>
</tr>
<tr>
<td width="326">
<p>1</p>
<p>2</p>
<p>3</p>
<p>45</p>
</td>
<td width="384">
<p>Time needed: 10h.</p>
</td>
<td width="764">
<p>All employess can answer 6 students per hour. In the first 3 hours they have answered 6 * 3 = 18 students. Then they have a break for an hour.</p>
<p>After the next 3 hours there are <br /> 18 + 6 * 3 = 36 answered students.</p>
<p>After the break for an hour, there are only 9 students to answer.</p>
<p>So in the 10th hour all of the student's questions would be answered.</p>
</td>
</tr>
<tr>
<td width="326">
<p>3</p>
<p>2</p>
<p>5</p>
<p>40</p>
</td>
<td width="384">
<p>Time needed: 5h.</p>
</td>
<td width="764">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>



<h1>Problem 2 &ndash; SoftUni Course Planning</h1>
<p>You are tasked to help planning the next Programing Fundamentals course by keeping track of the lessons, that are going to be included in the course, as well all the exercises for the lessons.</p>
<p>On the first input line you will <strong>receive the initial schedule of lessons and exercises</strong> that are going to be part of the next course, separated by<strong> comma and space ", ". </strong>But before the course starts, there are some changes to be made. Until you receive <strong>"course start"</strong> you will be given <strong>some commands to modify the course schedule</strong>. The possible commands are:</p>
<p>Add:{lessonTitle} &ndash; add the lesson to the end of the schedule, <strong>if it does not exist</strong>.</p>
<p>Insert:{lessonTitle}:{index} &ndash; insert the lesson to the given index, <strong>if the lesson does not exist and the index is valid.</strong></p>
<p>Remove:{lessonTitle} &ndash; remove the lesson, <strong>if it exists. If the lesson has an Exercise, remove it as well. </strong></p>
<p>Swap:{lessonTitle}:{lessonTitle} &ndash; swap the places of the two lessons, <strong>if they exist. If the lesson has an Exercise, change the Exercise position as well.</strong></p>
<p>Exercise:{lessonTitle} &ndash; add Exercise in the schedule right after the lesson index<strong><u>, if the lesson exists and there is no exercise already</u></strong>, in the following format "{lessonTitle}-Exercise". <strong>If the lesson doesn`t exist</strong>, <strong>Add the lesson</strong> in the end of the course schedule<strong>, followed by the Exercise</strong>.</p>
<p><strong>Each time you Swap or Remove</strong><strong> a lesson, you should do the same with the Exercises, if there are any, which follow the lessons.</strong></p>
<h2>Input / Constraints</h2>
<ul>
<li>first line &ndash; the initial schedule lessons &ndash; strings, separated by comma and space ", "</li>
<li>until <strong>"course start"</strong> you will receive commands in the format described above</li>
</ul>
<h2>Output</h2>
<ul>
<li>Print the whole course schedule, each lesson on a new line with its number(index) in the schedule: <br /> "{lesson index}.{lessonTitle}"</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="410">
<p><strong>Input</strong></p>
</td>
<td width="408">
<p><strong>Output</strong></p>
</td>
<td width="656">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="410">
<p>Data Types, Objects, Lists</p>
<p>Add:Databases</p>
<p>Insert:Arrays:0</p>
<p>Remove:Lists</p>
<p>course start</p>
</td>
<td width="408">
<p>1.Arrays</p>
<p>2.Data Types</p>
<p>3.Objects</p>
<p>4.Databases</p>
<p><strong>&nbsp;</strong></p>
</td>
<td width="656">
<p>We receive the initial schedule.</p>
<p>Next, we add Databases lesson, because it doesn`t exist.</p>
<p>We Insert at the given index lesson Arrays, because its not present in the schedule.</p>
<p>After receiving the last command and removing lesson Lists, we print the whole schedule.</p>
</td>
</tr>
<tr>
<td width="410">
<p><strong>Input</strong></p>
</td>
<td width="408">
<p><strong>Output</strong></p>
</td>
<td width="656">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="410">
<p>Arrays, Lists, Methods</p>
<p>Swap:Arrays:Methods</p>
<p>Exercise:Databases</p>
<p>Swap:Lists:Databases</p>
<p>Insert:Arrays:0</p>
<p>course start</p>
</td>
<td width="408">
<p>1.Methods</p>
<p>2.Databases</p>
<p>3.Databases-Exercise</p>
<p>4.Arrays</p>
<p>5.Lists</p>
</td>
<td width="656">
<p>We swap the given lessons, because both exist.</p>
<p>After receiving the Exercise command, we see that such lesson doesn`t exist, so we add the lesson at the end, followed by the exercise.</p>
<p>We swap Lists and Databases lessons, the Databases-Exercise is also moved after the Databases lesson.</p>
<p>We skip the next command, because we already have such lesson in our schedule.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>


<h1>Problem 3 &ndash; SoftUni Bar Income</h1>
<p>Let`s take a break and visit the game bar at SoftUni. It is about time for the people behind the bar to go home and you are the person who has to draw the line and calculate the money from the products that were sold throughout the day. Until you receive a line with text "end of shift" you will be given lines of input. But before processing that line you have to do some validations first.</p>
<p><strong>Each valid order </strong>should have a <strong>customer, product, count and a price:</strong></p>
<ul>
<li>Valid customer's name should be <strong>surrounded by '%' </strong>and must <strong>start with a capital letter</strong>, followed by <strong>lower-case letters</strong></li>
<li>Valid product <strong>contains any word character</strong> and must be <strong>surrounded by '&lt;' and '&gt;'</strong></li>
<li>Valid count is an <strong>integer</strong>, <strong>surrounded by '|'</strong></li>
<li>Valid price is any <strong>real number followed by '$'</strong></li>
</ul>
<p>The parts of a valid order should appear in the order given: <strong>customer, product, count and a price</strong>.</p>
<p>Between each part there can be other symbols, except (<strong>'|', '$', '%' and '.'</strong>)</p>
<p>For each valid line print on the console: "{customerName}: {product} - {totalPrice}"</p>
<p>When you receive "end of shift" print the total amount of money for the day <strong>rounded to 2 decimal places </strong>in the following format: "Total income: {income}"<strong>.</strong></p>
<h2>Input / Constraints</h2>
<ul>
<li>Strings that you have to process until you receive text "end of shift".</li>
</ul>
<h2>Output</h2>
<ul>
<li>Print all of the valid lines in the format "{customerName}: {product} - {totalPrice}"</li>
<li>After receiving "end of shift" print the total amount of money for the day rounded to 2 decimal places in the following format: "Total income: {income}"</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="506">
<p><strong>Input</strong></p>
</td>
<td width="468">
<p><strong>Output</strong></p>
</td>
<td width="500">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="506">
<p>%George%&lt;Croissant&gt;|2|10.3$</p>
<p>%Peter%&lt;Gum&gt;|1|1.3$</p>
<p>%Maria%&lt;Cola&gt;|1|2.4$</p>
<p>end of shift</p>
</td>
<td width="468">
<p>George: Croissant - 20.60</p>
<p>Peter: Gum - 1.30</p>
<p>Maria: Cola - 2.40</p>
<p>Total income: 24.30</p>
</td>
<td width="500">
<p>Each line is valid, so we print each order, calculating the total price of the product bought.</p>
<p>At the end we print the total income for the day</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="506">
<p>%InvalidName%&lt;Croissant&gt;|2|10.3$</p>
<p>%Peter%&lt;Gum&gt;1.3$</p>
<p>%Maria%&lt;Cola&gt;|1|2.4</p>
<p>%Valid%&lt;Valid&gt;valid|10|valid20$</p>
<p>end of shift</p>
</td>
<td width="468">
<p>Valid: Valid - 200.00</p>
<p>Total income: 200.00</p>
</td>
<td width="500">
<p>On the first line, the customer name isn`t valid, so we skip that line.<br /> The second line is missing product count.</p>
<p>The third line don`t have a valid price.</p>
<p>And only the forth line is valid</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>



<h1>Problem 4 &ndash; SoftUni Exam Results</h1>
<p>Judge statistics on the last Programing Fundamentals exam was not working correctly, so you have the task to take all the submissions and analyze them properly. You should collect all the submission and print the final results and statistics about each language that the participants submitted their solutions in.</p>
<p>You will be receiving lines in the following format: "{username}-{language}-{points}"<strong> until you receive </strong>"exam finished". You should store each username and his submissions and points. <br /> You can receive a <strong>command to ban</strong> a user for cheating in the following format: "{username}-banned". In that case, you should <strong>remove</strong> the user from the contest, but <strong>preserve his submissions in the total count of submissions for each language</strong>.</p>
<p>After receiving "exam finished" print each of the participants, ordered descending by their max points, then by username, in the following format:</p>
<p>Results:</p>
<p>{username} | {points}</p>
<p>&hellip;</p>
<p>After that print each language, used in the exam, ordered descending by total submission count and then by language name, in the following format:</p>
<p>Submissions:</p>
<p>{language} &ndash; {submissionsCount}</p>
<p>&hellip;</p>
<h2>Input / Constraints</h2>
<p>Until you receive "exam finished" you will be receiving participant submissions in the following format: "{username}-{language}-{points}".</p>
<p>You can receive a ban command -&gt; "{username}-banned"</p>
<p>The points of the participant will always be a <strong>valid integer in the range [0-100];</strong></p>
<h2>Output</h2>
<ul>
<li>Print the exam results for each participant, ordered descending by max points and then by username, in the following format:</li>
</ul>
<p>Results:</p>
<p>{username} | {points}</p>
<p>&hellip;</p>
<ul>
<li>After that print each language, ordered descending by total submissions and then by language name, in the following format:</li>
</ul>
<p>Submissions:</p>
<p>{language} &ndash; {submissionsCount}</p>
<p>&hellip;</p>
<ul>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="410">
<p><strong>Input</strong></p>
</td>
<td width="360">
<p><strong>Output</strong></p>
</td>
<td width="704">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="410">
<p>Pesho-Java-84</p>
<p>Gosho-C#-70</p>
<p>Gosho-C#-84</p>
<p>Kiro-C#-94</p>
<p>exam finished</p>
</td>
<td width="360">
<p>Results:</p>
<p>Kiro | 94</p>
<p>Gosho | 84</p>
<p>Pesho | 84</p>
<p>Submissions:</p>
<p>C# - 3</p>
<p>Java - 1</p>
</td>
<td width="704">
<p>When receiving Gosho for second time, we keep the better result.</p>
<p>We order the participant descending by max points and then by name, printing only the username and the max points.</p>
<p>After that we print each language along with the count of submissions, ordered descending by submissions count, and then by language name.</p>
</td>
</tr>
<tr>
<td width="410">
<p>Pesho-Java-91</p>
<p>Gosho-C#-84</p>
<p>Kiro-JavaScript-90</p>
<p>Kiro-C#-50</p>
<p>Kiro-banned</p>
<p>exam finished</p>
</td>
<td width="360">
<p>Results:</p>
<p>Pesho | 91</p>
<p>Gosho | 84</p>
<p>Submissions:</p>
<p>C# - 2</p>
<p>Java - 1</p>
<p>JavaScript - 1</p>
</td>
<td width="704">
<p>Kiro is banned so he is removed from the contest, but he`s submissions are still preserved in the languages submissions count.</p>
<p>So althou there are only 2 participants in the results, there are 4 submissions in total.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>