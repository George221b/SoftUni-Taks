<h1>Problem 1 &ndash; Rage Expenses</h1>
<p>As a MOBA challenger player, Pesho has the bad habit to trash his PC when he loses a game and rage quits. His gaming setup consists of <strong>headset, mouse, keyboard and display</strong>. You will receive Pesho`s <strong>lost games count</strong>.</p>
<p>Every <strong>second</strong> lost game, Pesho trashes his <strong>headset.</strong></p>
<p>Every <strong>third</strong> lost game, Pesho trashes his <strong>mouse</strong>.</p>
<p>When Pesho trashes <strong>both</strong> <strong>his mouse and headset </strong>in the <strong>same</strong> lost game, he also trashes his <strong>keyboard</strong>.</p>
<p><strong>Every</strong> <strong>second time, when he trashes his keyboard</strong>, he also trashes his <strong>display</strong>.</p>
<p>You will receive the price of each item in his gaming setup. Calculate his rage expenses for renewing his gaming equipment.</p>
<h2>Input / Constraints</h2>
<ul>
<li>On the first input line - <strong>lost games count </strong>&ndash; integer in the range <strong>[0</strong><strong>, 1000]</strong>.</li>
<li>On the second line &ndash; <strong>headset price</strong> - floating point number in range <strong>[0, 100</strong><strong>0</strong><strong>]</strong>.</li>
<li>On the third line &ndash; <strong>mouse price</strong> - floating point number in range <strong>[0, 100</strong><strong>0</strong><strong>]</strong>.</li>
<li>On the fourth line &ndash; <strong>keyboard price</strong> - floating point number in range <strong>[0, 100</strong><strong>0</strong><strong>]</strong>.</li>
<li>On the fifth line &ndash; <strong>display price</strong> - floating point number in range <strong>[0, 100</strong><strong>0</strong><strong>]</strong>.</li>
</ul>
<h2>Output</h2>
<ul>
<li>As output you must print Pesho`s total expenses: <strong>"Rage expenses: {expenses} lv."</strong></li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="326">
<p><strong>Input</strong></p>
</td>
<td width="444">
<p><strong>Output</strong></p>
</td>
<td width="704">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="326">
<p>7</p>
<p>2</p>
<p>3</p>
<p>4</p>
<p>5</p>
</td>
<td width="444">
<p>Rage expenses: 16.00 lv.</p>
</td>
<td width="704">
<p>Trashed headset -&gt; 3 times</p>
<p>Trashed mouse -&gt; 2 times</p>
<p>Trashed keyboard -&gt; 1 time</p>
<p>Total: 6 + 6 + 4 = 16.00 lv;</p>
</td>
</tr>
<tr>
<td width="326">
<p>23</p>
<p>12.50</p>
<p>21.50</p>
<p>40</p>
<p>200</p>
</td>
<td width="444">
<p>Rage expenses: 608.00 lv.</p>
</td>
<td width="704">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>


<h1>Problem 2 &ndash; Memory View</h1>
<p>As a Gamer, Pesho is thrilled with source code and is excited to have deeper understanding of the games code, so he started digging in the memory view. But because he can`t read it, you should write a programm which transforms the memory display in readable form.</p>
<p>Untill you receive <strong>"Visual Studio crash" </strong>you will be receiving lines from the memory view in 2-byte integer unsigned display. <strong>Each line</strong> consists of exactly 22 integers, separated by whitespace. You should find every string in the whole input and print them on the console.</p>
<p>Every string starts with -&gt; "32656 19759 32763"</p>
<p>After the pointer there is one zero and the size of the string -&gt; "0 5"</p>
<p>After the size of string there is one more zero and on the next n columns are the integers for</p>
<p>each character -&gt; <strong>"</strong><strong> 0 80 101 115 104 111" </strong></p>
<p>The above example is the string "Pesho".</p>
<p>You must find all strings and display them on the console, using the <strong>ASCII code for each character.</strong></p>
<h2>Input</h2>
<ul>
<li>The input will consist of <strong>several</strong> <strong>lines of 22 integers, separated by spaces</strong>.</li>
</ul>
<h2>Output</h2>
<ul>
<li>You should print on a new line every string you`ve found in the input in their order of appearance.</li>
</ul>
<h2>Constraints</h2>
<ul>
<li>The lines of the input may contain any 32-bit integer in the range [0 &ndash; 32763].</li>
<li>The input will allways be valid.</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table>
<tbody>
<tr>
<td width="1127">
<p><strong>Input</strong></p>
</td>
<td width="263">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1127">
<p>32656 19759 32763 0 5 0 80 101 115 104 111 0 0 0 0 0 0 0 0 0 0 0</p>
<p>0 32656 19759 32763 0 7 0 83 111 102 116 117 110 105 0 0 0 0 0 0 0 0</p>
<p>Visual Studio crash</p>
</td>
<td width="263">
<p>Pesho</p>
<p>Softuni</p>
</td>
</tr>
<tr>
<td width="1127">
<p>0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 32656 19759 32763 0</p>
<p>5 0 80 101 115 104 111 0 0 0 0 0 0 0 0 0 32656 19759 32763 0 4 0</p>
<p>75 105 114 111 0 0 0 0 0 0 0 0 0 0 32656 19759 32763 0 8 0 86 101</p>
<p>114 111 110 105 107 97 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0</p>
<p>Visual Studio crash</p>
</td>
<td width="263">
<p>Pesho</p>
<p>Kiro</p>
<p>Veronika</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>



<h1>Problem 3 &ndash; Tseam Account</h1>
<p>As a gamer, Pesho has Tseam Account. He loves to buy new games. You are given Pesho`s account with all of his games-&gt; strings, separated by space. Until you receive <strong>"Play!" </strong>you will be receiving commands which Pesho does with his account.</p>
<p>You may receive the following commands:</p>
<ul>
<li>Install {game}</li>
<li>Uninstall {game}</li>
<li>Update {game}</li>
<li>Expansion {game}-{expansion}</li>
</ul>
<p>If you receive <strong>Install command</strong>, you should <strong>add</strong> the game at last position in the account, but only if it isn`t installed already.</p>
<p>If you receive <strong>Uninstall command</strong>, <strong>delete</strong> the game if it exists.</p>
<p>If you receive <strong>Update command</strong>, you should <strong>update</strong> the game if it exists and place it on <strong>last position</strong>.</p>
<p>If you receive <strong>Expansion command</strong>, you should check if the game exists and <strong>insert</strong> after it the expansion in the following format: "<strong>{game}:{expansion}";</strong></p>
<h2>Input</h2>
<ul>
<li>On the <strong>first input line</strong> you will receive Pesho`s <strong>account</strong> &ndash; sequence of game names, separated by space.</li>
<li>Until you receive <strong>"Play!"</strong> you will be receiving <strong>commands</strong>.</li>
</ul>
<h2>Output</h2>
<ul>
<li>As output you must print Pesho`s Tseam <strong>account</strong>.</li>
</ul>
<h2>Constraints</h2>
<ul>
<li>The<strong> command will always be valid.</strong></li>
<li>The <strong>game </strong>and <strong>expansion</strong> will be strings and will contain any character, except <strong>'-'</strong>.</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="326">
<p><strong>Input</strong></p>
</td>
<td width="408">
<p><strong>Output</strong></p>
</td>
<td width="740">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="326">
<p>CS WoW Diablo</p>
<p>Install LoL</p>
<p>Uninstall WoW</p>
<p>Update Diablo</p>
<p>Expansion CS-Go</p>
<p>Play!</p>
</td>
<td width="408">
<p>CS CS:Go LoL Diablo</p>
</td>
<td width="740">
<p>We receive the account =&gt; CS, WoW, Diablo</p>
<p>We Install LoL =&gt; CS, WoW, Diablo, LoL</p>
<p>Uninstall WoW =&gt; CS, Diablo, LoL</p>
<p>Update Diablo =&gt; CS, LoL, Diablo</p>
<p>We add expansion =&gt; CS, CS:Go, LoL, Diablo</p>
<p>We print the account.</p>
</td>
</tr>
<tr>
<td width="326">
<p>CS WoW Diablo</p>
<p>Uninstall XCOM</p>
<p>Update PeshoGame</p>
<p>Update WoW</p>
<p>Expansion Civ-V</p>
<p>Play!</p>
</td>
<td width="408">
<p>CS Diablo WoW</p>
</td>
<td width="740">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>


<h1>Problem 4. MOBA Challenger</h1>
<p>Pesho is a pro MOBA player, he is struggling to become master of the Challenger tier. So he watches carefully the statistics in the tier.</p>
<p>You will receive <strong>several input lines</strong> in one of the following formats:</p>
<p>"{player} -&gt; {position} -&gt; {skill}"</p>
<p>"{player} vs {player}"</p>
<p>The player and position are strings, the given <strong>skill</strong> will be an integer number. You need to keep track of <strong>every player</strong>.</p>
<p>When you receive a <strong>player and his position and skill</strong>, add him to the player pool, if he isn`t present, <strong>else add</strong> his position and skill <strong>or update</strong> his skill, only if the current position skill is lower than the new value.</p>
<p>If you receive <strong>"{player} vs {player}"</strong> and <strong>both players exist</strong> in the tier, <strong>they duel</strong> with the following rules:</p>
<p>Compare their positions, <strong>if they got at least one in common</strong>, the player with better <strong>total skill points</strong> wins and the other is <strong>demoted </strong>from the tier -&gt; remove him. If they have same total skill points, <strong>the duel is tie</strong> and they both continue in the Season.</p>
<p>If they don`t have positions in common, <strong>the duel isn`t happening</strong> and both continue in the Season.</p>
<p>You should end your program when you receive the command "Season end". At that point you should print the players, <strong>ordered by total skill in desecending order, then ordered by player name in ascending order</strong>. <strong>Foreach</strong> player print their position and skill, <strong>ordered desecending by skill, then ordered by position name in ascending order.</strong></p>
<h2>Input / Constraints</h2>
<ul>
<li>The input comes in the form of commands in one of the formats specified above.</li>
<li>Player and position <strong>will always be one word string, containing no whitespaces</strong>.</li>
<li>Skill will be an <strong>integer</strong> in the <strong>range [0, 1000]</strong>.</li>
<li>There will be <strong>no invalid</strong> input lines.</li>
<li>The programm ends when you receive the command "Season end".</li>
</ul>
<h2>Output</h2>
<ul>
<li>The output format for each player is:</li>
</ul>
<p>"{player}: {totalSkill} skill"</p>
<p>"- {position} &lt;::&gt; {skill}"</p>
<h2>Examples</h2>
<table width="1436">
<tbody>
<tr>
<td width="416">
<p><strong>Input</strong></p>
</td>
<td width="431">
<p><strong>Output</strong></p>
</td>
<td width="589">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="416">
<p>Pesho -&gt; Adc -&gt; 400</p>
<p>Gosho -&gt; Jungle -&gt; 300</p>
<p>Stamat -&gt; Mid -&gt; 200</p>
<p>Stamat -&gt; Support -&gt; 250</p>
<p>Season end</p>
</td>
<td width="431">
<p>Stamat: 450 skill</p>
<p>- Support &lt;::&gt; 250</p>
<p>- Mid &lt;::&gt; 200</p>
<p>Pesho: 400 skill</p>
<p>- Adc &lt;::&gt; 400</p>
<p>Gosho: 300 skill</p>
<p>- Jungle &lt;::&gt; 300</p>
</td>
<td width="589">
<p>We order the players by total skill points descending, then by name. We print every position along its skill ordered descending by skill, then by position name.</p>
</td>
</tr>
<tr>
<td width="416">
<p><strong>Input</strong></p>
</td>
<td width="431">
<p><strong>Output</strong></p>
</td>
<td width="589">
<p><strong>&nbsp;</strong></p>
</td>
</tr>
<tr>
<td width="416">
<p>Pesho -&gt; Adc -&gt; 400</p>
<p>Bush -&gt; Tank -&gt; 150</p>
<p>Faker -&gt; Mid -&gt; 200</p>
<p>Faker -&gt; Support -&gt; 250</p>
<p>Faker -&gt; Tank -&gt; 250</p>
<p>Pesho vs Faker</p>
<p>Faker vs Bush</p>
<p>Faker vs Hide</p>
<p>Season end</p>
</td>
<td width="431">
<p>Faker: 700 skill</p>
<p>- Support &lt;::&gt; 250</p>
<p>- Tank &lt;::&gt; 250</p>
<p>- Mid &lt;::&gt; 200</p>
<p>Pesho: 400 skill</p>
<p>- Adc &lt;::&gt; 400</p>
</td>
<td width="589">
<p>Faker and Pesho don`t have common position, so the duel isn`t valid.</p>
<p>Faker wins vs Bush /common position: "Tank". Bush is demoted.</p>
<p>Hide doesn`t exist so the duel isn`t valid.</p>
<p>We print every player left in the tier.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>