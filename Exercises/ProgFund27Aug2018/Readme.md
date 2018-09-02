<h1>Problem 1 &ndash; Hogswatch</h1>
<p><em>Here is the problem, the Hogfather can travel to all the homes in one night it&rsquo;s a wonder right! But somehow he just can&rsquo;t handle math. He forgot the number of presents he has to give, all that he can remember is the number of homes. You need to help him and save Hogswatch!!!</em></p>
<p>You are given the number <strong>of homes N the Hogfather has to visit</strong>, on the first line.</p>
<p>And then the <strong>total </strong>number <strong>of presents he took </strong>when leaving the workshop on the second line<strong>.</strong></p>
<p>In each home Hogfather visits he <strong>counts the number of socks above the fireplace and gives you that number.</strong> <strong>If he runs out of presents </strong>he has to go back to the workshop for<strong> more. </strong></p>
<p>The number of presents he has to get is equal to <strong>the integer value of initial presents divided (integer division) by homes visited</strong> including the current one.<strong> Multiplied by the number of remaining homes, plus the number of presents he needs in addition for the current home or in other words:</strong></p>
<p><strong>({initialPresents} / {visitedHomes}) * {remainingHomes} + {additionalPresents}</strong></p>
<p><strong>There are two possible outputs:</strong></p>
<ul>
<li><strong>If the initial number of presents is enough you print the remaining presents on a single line</strong></li>
<li>On a single line the number of presents left - <strong>{presentsNumber}</strong></li>
<li><strong>If the Hogfather run out of presents at some point print two lines</strong></li>
<li>On the first line print &ndash; <strong>total number of times he went back</strong> <strong>-</strong> <strong>{timesBack}</strong></li>
<li>On the second line print &ndash; <strong>total number of presents he took in addition</strong> <strong>-</strong> <strong>{additionalPresentsTaken}</strong></li>
</ul>
<h2>Input / Constraints</h2>
<ul>
<li>On the first line <strong>N</strong> <strong>homes to visit</strong> &ndash; integer in range <strong>[1 - 100]</strong></li>
<li>On the second line &ndash; <strong>initial number of presents </strong>&ndash; integer in range <strong>[1 &ndash; 10000]</strong></li>
<li><strong>On the next N lines the number of children per house &ndash; integer in range[1-100]</strong></li>
<li>Input will always be valid and in the range specified you don&rsquo;t need to check it</li>
</ul>
<h2>Output</h2>
<ul>
<li>On of the two possible outputs specified above</li>
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
<p>20</p>
<p>2</p>
<p>1</p>
<p>3</p>
<p>9</p>
<p>5</p>
</td>
<td width="384">
<p>0</p>
</td>
<td width="764">
<p>The Hogfather needs to visit 5 homes</p>
<p>He went out with 20 presents</p>
<p>In the first house he left 2 presents, then in the second he left 1 present. After that he left 3 presents, then 9 presents, and in the last house 5 presents. There were enough presents so out of 20 he gave 20 and we print 0 as the ramaining number of presents.</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="326">
<p>4</p>
<p>20</p>
<p>12</p>
<p>10</p>
<p>3</p>
<p>9</p>
</td>
<td width="384">
<p>1</p>
<p>22</p>
</td>
<td width="764">
<p>The Hogfather needs to visit 4 homes</p>
<p>He went out with 20 presents</p>
<p>In the first house he left 12 presents, then in the second, he have to leave 10 presents, but he has only 8 left. So he goes back, the number of presents he takes this time is equal to 20 (initial presents) devided by homes visited so far (including current home) multiplied by 2 (homes remaining) that is equal to 20 then we add 2 presents he needs to leave in the current home. So he goes back 1 time and brings 22 presents. He moves to the next homes, but he doesn&rsquo;t go back anymore.</p>
</td>
</tr>
<tr>
<td width="326">
<p>5</p>
<p>10</p>
<p>4</p>
<p>5</p>
<p>3</p>
<p>4</p>
<p>5</p>
</td>
<td width="384">
<p>2</p>
<p>11</p>
</td>
<td width="764">
<p>The Hogfather needs to visit 5 homes</p>
<p>He went out with 10 presents</p>
<p>At the first home he left 4 presents. At the second home he left 5 presents. At the third home he has only 1 present remaining so he needs to go back for more. He takes (10 / 3) * 2 + 2 = 8 presents, then leaves 2 in the current home. He moves to the fourth home, here he leaves 4 presents. At the fifth home he needs to leave 5 presents, but he has only 2, so he goes back second time. He takes (10 / 5) * 0 + 3 = 3 presents. So in total he went back 2 times and got totally 11 presents 8 the first time and 3 the seocond.</p>
</td>
</tr>
</tbody>
</table>
<p><em>&nbsp;</em></p>
<p><em>&ldquo;Do you know, that in a universe so full of wonders, we have managed to invent boredom&hellip;&rdquo;</em></p>


<h1>Problem 2 &ndash; Grains of Sand</h1>
<p><em>You have become an apprentice! Congratulations or maybe&hellip;&hellip; regrets. Since you are working for the almighty Anthropomorphic personification &ndash; Death he is known for his work of taking care for all the world&rsquo;s sand watches, he seems to deal with this job pretty well, but you as a programmer want to help him, and make his job easier.</em></p>
<p>You are given <strong>all the grains</strong> of each sand watch in <strong>a sequence on a single line, separated by spaces</strong>. After that, you will receive <strong>commands</strong> that modify the grains in a different way:</p>
<p><strong>"Add </strong><strong>{grains}</strong><strong>"</strong>, means that you have to add <strong>{grains}</strong> to the end of the sequence, grains value will always be integer.</p>
<p><strong>"Remove </strong><strong>{grains}</strong><strong>"</strong>, means that you have to remove the first element in the sequence with value equal to <strong>{grains}</strong> starting from the beginning. If there is no such element you have to <strong>check if the value is a valid index</strong> for the sequence and <strong>remove the element at that index</strong>, however if both the <strong>element is not valid and the value is not a valid index </strong>you should ignore that command.</p>
<p><strong>"Replace </strong><strong>{toReplace} {replacement}</strong><strong>"</strong> you have to find <strong>the first occurrence of the element</strong> equal to <strong>{toReplace}</strong> and replace it with the <strong>{replacement}.</strong> If element equal to <strong>{toReplace} </strong>doesn&rsquo;t exists in the sequence you have to ignore this command.</p>
<p><strong>"Increase </strong><strong>{grains}</strong><strong>"</strong> you have to find the first element with <strong>value</strong> <strong>not less than </strong><strong>{grains} </strong>and <strong>increase the value of all elements</strong> in the sequence with this value. <strong>If no such element exists in the set, you have to take the last element from the sequence</strong> and then <strong>increase the value of all elements</strong> in the sequence with this value.</p>
<p><strong>"Collapse {grains}"</strong> you have to <strong>remove from the sequence every element with value less</strong> than <strong>{grains}</strong>, if there are such elements.</p>
<p>When you receive command <strong>"Mort"</strong> you have to <strong>print the modified sequence</strong> and end the program.</p>
<h2>Input / Constraints</h2>
<ul>
<li>On the first line &ndash; count of sands in each watch separated by spaces &ndash; integers in range</li>
</ul>
<p><strong>[-2,147,483,648&hellip;&hellip;2,147,483,647]</strong></p>
<ul>
<li>On the next lines you will receive commands untill <strong>"Mort"</strong> command is received.</li>
<li>The commands will always be valid.</li>
</ul>
<h2>Output</h2>
<ul>
<li>Print a single line the array of grains separated by spaces, with the modified values.</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong></li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="398">
<p><strong>Input</strong></p>
</td>
<td width="336">
<p><strong>Output</strong></p>
</td>
<td width="740">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="398">
<p>1 4 5 19 13 42 69 24</p>
<p>Add 1</p>
<p>Remove 3</p>
<p>Remove 4</p>
<p>Remove 15</p>
<p>Replace 0 26</p>
<p>Replace 1 26</p>
<p>Mort</p>
<p>&nbsp;</p>
</td>
<td width="336">
<p>26 5 13 42 69 24 1</p>
</td>
<td width="740">
<p>The sequence &ndash; [1 4 5 19 13 42 69 24]</p>
<p>We start with "Add 1" so we add 1 to the end of the sequence and it looks like &ndash; [1 4 5 19 13 42 69 24 1]. The next command is "Remove 3" &ndash; [1 4 5 13 42 69 24 1]. The next command is "Remove 4" &ndash; [1 5 13 42 69 24 1]. The next command is "Remove 15" &ndash; [1 5 13 42 69 24 1]. The next command is "Replace 0 26" &ndash; [1 5 13 42 69 24 1]. The next command is "Replace 1 26" &ndash; [26 5 13 42 69 24 1]. We read "Mort", and print the sequence.</p>
</td>
</tr>
<tr>
<td width="398">
<p>1 2 -1 0 -3 9 8 7 2</p>
<p>Increase 10</p>
<p>Increase 90</p>
<p>Collapse 8</p>
<p>Mort</p>
</td>
<td width="336">
<p>8 15 14 13 8</p>
</td>
<td width="740">
<p>The sequence &ndash; [1 2 -1 0 -3 9 8 7 2]</p>
<p>&nbsp;</p>
<p>The first one is "Increase 10" so we increase the sequence by 2 &ndash; [3 4 1 2 -1 11 10 9 4]. The next one is "Increase 90" so we increase the sequence with 4 &ndash; [7 8 5 6 3 15 14 13 8]. The next one is "Collapse 8" &ndash; so we remove all the elements less than 8 &ndash; [8 15 14 13 8]. The last one is "Mort" so we print the sequence.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p><em>&ldquo;I am the defeater of empires, the thief of years, the ultimate reality. And my horse is called Binky, it&rsquo;s a nice name.&rdquo;</em></p>



<h1>Problem 3 &ndash; Post Office</h1>
<p><em>The post office is running well, after the breakthrough of the technologies, but people demand security. That's why Moist von Lipwig, started encrypting the messages. After all he forgot what was the way to decipher them, and here you go, you have to help him or&hellip;. He will be terribly hurt by a pair of high heels.</em></p>
<p><strong>You read a single line of ASCII symbols</strong>, and the message is somewhere inside it, you must find it.</p>
<p>&nbsp;The input consists of three parts separated with <strong>"|"</strong> like this:</p>
<p><strong>"{firstPart}|{secondPart}|{thirdPart}"</strong></p>
<p>Each word <strong>starts with capital letter</strong> and <strong>has a fixed length</strong>, you can find those in each different part of the input.</p>
<p>The <strong>first part</strong> carries the capital letters for each word inside the message. You need to find those capital letters <strong>1 or more</strong> <strong>from A to Z</strong>. The capital letters should be surrounded from the both sides with any of the following symbols &ndash; <strong>"#, $, %, *, &amp;". </strong>And those symbols <strong>should match on the both sides.</strong> This means that <strong>$AOTP$ - is a valid</strong> pattern for the capital letters. <strong>$AKTP% - is invalid since the symbols do not match.</strong></p>
<p>The <strong>second part</strong> of the data contains the <strong>starting letter ASCII code and words</strong> <strong>length</strong> /<strong>between 1 &ndash; 20 charactes</strong><strong>/</strong>, in the following format: <strong>"{asciiCode}:{length}"</strong>. For example, "<strong>67:05</strong>" &ndash; means that '67' - <strong>ascii code</strong> <strong>equal to the capital letter</strong> <strong>"C",</strong> represents a word starting with "C" with following 5 characters: like <strong>"Carrot".</strong> The <strong>ascii code</strong> should be a <strong>capital letter equal to a letter from the first part</strong>. Word's length <strong>should be exactly 2 digits</strong>. Length <strong>less than</strong> <strong>10 will always have a padding zero</strong>,<strong> you don't need to check that. </strong></p>
<p>The <strong>third part of the message</strong> are <strong>words separated by spaces.</strong> Those <strong>words have to start with Capital letter [A&hellip;Z] equal to the ascii code and have exactly the length for each capital letter you have found in the second part. Those words can contain any ASCII symbol without spaces.</strong></p>
<p>When you find <strong>valid word</strong>, you have to <strong>print it on a new line</strong>.</p>
<h2>Input / Constraints</h2>
<ul>
<li>On the first line &ndash; the text in form of three different parts separated by <strong>"|". There can be any ASCII character inside the input, except '|'.</strong></li>
<li>Input will always be valid - you don&rsquo;t need to check it</li>
<li>The input will always have three different parts, that will always be separated by "|".</li>
</ul>
<h2>Output</h2>
<ul>
<li>Print all extracted words, each on a new line.</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong></li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="782">
<p><strong>Input</strong></p>
</td>
<td width="324">
<p><strong>Output</strong></p>
</td>
<td width="368">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="782">
<p>sdsGGasAOTPWEEEdas$AOTP$|a65:1.2s65:03d79:01ds84:02! -80:07++ABs90:1.1|adsaArmyd Gara So La Arm Armyw21 Argo O daOfa Or Ti Sar saTheww The Parahaos</p>
</td>
<td width="324">
<p>Argo</p>
<p>Or</p>
<p>The</p>
<p>Parahaos</p>
</td>
<td width="368">
<p>The capital letters are "AOTP"</p>
<p>Then we look for the addition length of the words for each capital letter. For A(65) -&gt; it's 4. For O(79) -&gt; it's 2 For T(84) -&gt; it's 3 For P(80) -&gt; it's 8.</p>
<p>Then we search in the last part for the words.First, start with letter 'A' and we find "Argo". With letter 'O' we find &nbsp;"Or". With letter 'T' we find "The" and with letter 'P' we find "Parahaos".</p>
</td>
</tr>
<tr>
<td width="782">
<p>Urgent"Message.TO$#POAML#|readData79:05:79:0!2reme80:03--23:11{79:05}tak{65:11ar}!77:!23--)77:05ACCSS76:05ad|Remedy Por Ostream :Istream Post sOffices Office Of Ankh-Morpork MR.LIPWIG Mister Lipwig</p>
<p>&nbsp;</p>
</td>
<td width="324">
<p>Post</p>
<p>Office</p>
<p>Ankh-Morpork</p>
<p>Mister</p>
<p>Lipwig</p>
</td>
<td width="368">
<p>The first capital letters are "POAML"</p>
<p>Then we look for the addition length of the words for each capital letter.</p>
<p>P(80) -&gt; it's 4.</p>
<p>O(79) -&gt; it's 6</p>
<p>A(65) -&gt; it's 12</p>
<p>M(77) -&gt; it's 6</p>
<p>L(76) -&gt; it's 6.</p>
<p>Then we search the last part for the words. First, start with the letter 'P' and we find "Post". With letter 'O' we find "Office". With letter 'A' we find "Ankh-Morpork". With letter 'M' we find "Mister" and with letter 'L' we find "Lipwig".</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><em>&ldquo;Welcome to fear, said Moist to himself. It's hope, turned inside out. You know it can't go wrong, you're sure it can't go wrong...But it might.&rdquo;</em></p>


<h1>Problem 4 &ndash; Iron Girder</h1>
<p><em>As a thinker you are always given new tasks. This time you are working for Mr. Harry King. You have to take part in the new railway system and keep track on how things are going there.</em></p>
<p>You will receive input lines in one of the following formats:</p>
<p><strong>{townName}:{time}-&gt;{passengersCount} </strong></p>
<p>If you receive the line above, Iron Girder has travelled to <strong>certain town</strong> for a <strong>certain amount of time</strong> with <strong>certain count of passengers</strong>. You need to keep track <strong>for each town</strong>. You have to save <strong>the fastest time Iron Girder reaches</strong> a town and the <strong>total count of passengers for each town.</strong></p>
<p><strong>{townName}:ambush-&gt;{passengersCount}</strong></p>
<p>If you receive the line above, somewhere along the track to the current town <strong>Iron Girder was ambushed and the passengers can't reach there.</strong> If this happens you need to <strong>set the time record for this town to "0" and remove the current count of passengers from the total count.</strong> If it's the <strong>first time Iron Girder travels to this town</strong> then you <strong>simply ignore this line.</strong></p>
<p>When you receive <strong>"Slide rule"</strong> you end the program and print data for each town in the following format:</p>
<p><strong>"{townName} -&gt; Time: {fastestTime} -&gt; Passengers: {totalCountPassengers}"</strong></p>
<p>The output should be ordered by best time and then by town's name. If a town is with no recorded time <strong>(the time is equal to 0) or there are no passengers (count is equal or less than 0) </strong>you <strong>should not print it.</strong></p>
<h2>Input / Constraints</h2>
<ul>
<li>Until you receive <strong>"Slide rule"</strong> you will be receiving participant submissions in one of the formats specified above</li>
<li>The time will always be <strong>positive</strong> <strong>integer in the range [1-1000]</strong></li>
<li>The count of passengers will always be<strong> positive integer in the range [1-100000]</strong></li>
</ul>
<h2>Output</h2>
<ul>
<li>Print recorded data in the following format:</li>
<li><strong>"{townName} -&gt; Time: {bestTime} -&gt; Passengers: {totalCountPassengers}"</strong></li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong></li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="422">
<p><strong>Input</strong></p>
</td>
<td width="708">
<p><strong>Output</strong></p>
</td>
<td width="344">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="422">
<p>Sto-Lat:8-&gt;120</p>
<p>Ankh-Morpork:3-&gt;143</p>
<p>Sto-Lat:9-&gt;80</p>
<p>Ankh-Morpork:4-&gt;143</p>
<p>Sto-Lat:3-&gt;20</p>
<p>Quirm:12-&gt;40</p>
<p>Quirm:13-&gt;29</p>
<p>Slide rule</p>
</td>
<td width="708">
<p>Ankh-Morpork -&gt; Time: 3 -&gt; Passengers: 286</p>
<p>Sto-Lat -&gt; Time: 3 -&gt; Passengers: 220</p>
<p>Quirm -&gt; Time: 12 -&gt; Passengers: 69</p>
</td>
<td width="344">
<p>We have Sto-Lat multiple times, but we keep only the best time equal to 3 with the total count of passengers equal to 220. Ankh- Morpork is with fastest time 3, so we compare those two by names. Quirm comes third with time of 12.</p>
</td>
</tr>
<tr>
<td width="422">
<p>Quirm:12-&gt;258</p>
<p>Ankh-Morpork:ambush-&gt;200</p>
<p>Ankh-Morpork:3-&gt;143</p>
<p>Sto-Lat:4-&gt;80</p>
<p>Ankh-Morpork:4-&gt;143</p>
<p>Ankh-Morpork:ambush-&gt;143</p>
<p>Sto-Lat:3-&gt;20</p>
<p>Ankh-Morpork:5-&gt;17</p>
<p>Slide rule</p>
</td>
<td width="708">
<p>Sto-Lat -&gt; Time: 3 -&gt; Passengers: 100</p>
<p>Ankh-Morpork -&gt; Time: 5 -&gt; Passengers: 160</p>
<p>Quirm -&gt; Time: 12 -&gt; Passengers: 258</p>
</td>
<td width="344">
<p>The record time for Ankh-Morpork is equal to 5 since the previos one was set to 0 during the ambush. Note that we keep the count of passengers.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&ldquo;It was like ... like wizardry, but without the wizards and the mess.&rdquo;</p>