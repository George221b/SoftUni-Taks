<h1>Problem 1. Padawan Equipment</h1>
<p>Yoda is starting his newly created Jedi academy. So, he asked master Ivan Cho to <strong>buy</strong> the <strong>needed equipment</strong>. The number of <strong>items</strong> depends on <strong>how many students will sign up</strong>. The equipment for the Padawan contains <strong>lightsabers, belts and robes</strong>.</p>
<p>You will be given <strong>the amount of money Ivan Cho has</strong>, the <strong>number of students </strong>and the <strong>prices of each item</strong>. You have to help Ivan Cho <strong>calculate</strong> if the <strong>money</strong> he has is <strong>enough to buy all of the equipment</strong>, or how much more money he needs. <br /> Because the lightsabres sometimes brake, Ivan Cho should <strong>buy 10% more</strong>, <strong>rounded up</strong> to the next integer. Also, every <strong>sixth belt is free</strong>.</p>
<h2>Input / Constraints</h2>
<p>The input data should be read from the console. It will consist of <strong>exactly 5 lines</strong>:</p>
<ul>
<li>The <strong>amount of money</strong> Ivan Cho has &ndash; <strong>floating-point number</strong> in <strong>range [0.0</strong><strong>0&hellip;1,000.00]</strong></li>
<li>The <strong>count of students &ndash; integer in range [0&hellip;100]</strong></li>
<li>The <strong>price of lightsabers</strong> for a <strong>single </strong><strong>sabre &ndash; floating-point number</strong> in <strong>range [0.</strong><strong>00&hellip;100.00]</strong></li>
<li>The <strong>price of robes</strong> for a <strong>single robe &ndash; floating-point number</strong> in <strong>range [0.</strong><strong>00&hellip;100.00]</strong></li>
<li>The <strong>price of belts</strong> for a <strong>single</strong> <strong>belt &ndash; floating-point number</strong> in <strong>range [0.0</strong><strong>0&hellip;100.00]</strong></li>
</ul>
<p>The <strong>input data will always be valid</strong>. <strong>There is no need to check it explicitly</strong>.</p>
<h2>Output</h2>
<p>The output should be printed on the console.</p>
<ul>
<li><strong>If the calculated price of the equipment is less or equal to the money Ivan Cho has:</strong>
<ul>
<li>"The money is enough - it would cost {the cost of the equipment}lv."</li>
</ul>
</li>
<li><strong>If the calculated price of the equipment is more than the money Ivan Cho has:</strong>
<ul>
<li>"Ivan Cho will need {neededMoney}lv more."</li>
</ul>
</li>
<li><strong>All prices</strong> must be <strong>rounded to two digits after the decimal point.</strong></li>
</ul>
<h2>Examples</h2>
<table width="1403">
<tbody>
<tr>
<td width="100">
<p><strong>Input</strong></p>
</td>
<td width="607">
<p><strong>Output</strong></p>
</td>
<td width="696">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="100">
<p>100</p>
<p>2</p>
<p>1.0</p>
<p>2.0</p>
<p>3.0</p>
</td>
<td width="607">
<p>The money is enough - it would cost 13.00lv.</p>
</td>
<td width="696">
<p>Needed equipment for 2 padawans&nbsp; :</p>
<p>sabresPrice*(studentsCount + 10%) + robesPrice * (studentsCount) + beltsPrice*(studentsCount-freeBelts)</p>
<p>1*(3) + 2*(2) + 3*(2) = 13.00</p>
<p>13.00 &lt;= 100 &ndash; the money will be enough.</p>
</td>
</tr>
<tr>
<td width="100">
<p><strong>Input</strong></p>
</td>
<td width="607">
<p><strong>Output</strong></p>
</td>
<td width="696">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="100">
<p>100</p>
<p>42</p>
<p>12.0</p>
<p>4.0</p>
<p>3.0</p>
</td>
<td width="607">
<p>Ivan Cho will need 737.00lv more.</p>
</td>
<td width="696">
<p>Needed equipment for 42 padawans:</p>
<p>12*47 + 4*42 + 3*35 = 837.00</p>
<p>837 &gt; 100 &ndash; need 737.00 lv. more.</p>
</td>
</tr>
</tbody>
</table>
<p><em>...May</em><em> the force<br /> &nbsp;be with you...</em></p>

<h1>Problem 2. Kamino Factory</h1>
<p>The clone factory in Kamino got another order to clone troops. But this time you are tasked to find <strong>the best DNA</strong> sequence to use in the production.</p>
<p>You will receive the <strong>DNA length</strong> and until you receive the command <strong>"Clone them!"</strong> you will be receiving a <strong>DNA sequences of ones and zeroes, split by "!"</strong> <strong>(one or several).</strong></p>
<p>You should select the sequence with the <strong>longest subsequence of ones</strong>. If there are several sequences with <strong>same length of</strong> <strong>subsequence of ones</strong>, print the one with the <strong>leftmost</strong> <strong>starting index</strong>, if there are several sequences with same <strong>length and starting index</strong>, select the sequence with the <strong>greater sum</strong> of its elements.</p>
<p>After you receive the last command "Clone them!" you should print the collected information in the following format:</p>
<p>"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."</p>
<p>"{DNA sequence, joined by space}"</p>
<h2>Input / Constraints</h2>
<ul>
<li>The <strong>first line</strong> holds the <strong>length</strong> of the <strong>sequences</strong> &ndash; <strong>integer in range [1&hellip;100];</strong></li>
<li>On the next lines until you receive <strong>"Clone them!"</strong> you will be receiving sequences (at least one) of ones and zeroes, <strong>split by "!"</strong> (one or several).</li>
</ul>
<h2>&nbsp;Output</h2>
<p>The output should be printed on the console and consists of two lines in the following format:</p>
<p>"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."</p>
<p>"{DNA sequence, joined by space}"</p>
<h2>&nbsp;Examples</h2>
<table width="1404">
<tbody>
<tr>
<td width="239">
<p><strong>Input</strong></p>
</td>
<td width="516">
<p><strong>Output</strong></p>
</td>
<td width="648">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="239">
<p>5</p>
<p>1!0!<strong>1!1</strong>!0</p>
<p>0!<strong>1!1</strong>!0!0</p>
<p>Clone them!</p>
</td>
<td width="516">
<p>Best DNA sample 2 with sum: 2.</p>
<p>0 1 1 0 0</p>
</td>
<td width="648">
<p>We receive 2 sequences with <strong>same length</strong> <strong>of subsequence of ones</strong>, but the second is printed, because its subsequence starts at <strong>index[1].</strong></p>
</td>
</tr>
<tr>
<td width="239">
<p><strong>Input</strong></p>
</td>
<td width="516">
<p><strong>Output</strong></p>
</td>
<td width="648">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="239">
<p>4</p>
<p><strong>1!1</strong>!0!<strong>1</strong></p>
<p>1!0!0!1</p>
<p><strong>1!1</strong>!0!0</p>
<p>Clone them!</p>
</td>
<td width="516">
<p>Best DNA sample 1 with sum: 3.</p>
<p>1 1 0 1</p>
</td>
<td width="648">
<p>We receive 3 sequences. Both 1 and 3 <strong>have same length</strong> of subsequence of ones -&gt; 2, <strong>and both start from index[0]</strong>, but the first is printed, because its <strong>sum is greater.</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>"FEAR IS THE PATH TO THE DARK SIDE...</p>
<p>FEAR LEADS TO ANGER...</p>
<p>ANGER LEADS TO HATE...</p>
<p>HATE LEADS TO SUFFERING...."</p>

<h1>Problem 3. Star Enigma</h1>
<p>The war is in its peak, but you, young Padawan, can turn the tides with your programming skills. You are tasked to create a program to <strong>decrypt</strong> the messages of The Order and prevent the death of hundreds of lives.</p>
<p>You will receive several messages, which are <strong>encrypted</strong> using the legendary star enigma. You should <strong>decrypt the messages</strong>, following these rules:</p>
<p>To properly decrypt a message, you should <strong>count all the letters</strong> <strong>[s, t, a, r]</strong> &ndash; <strong>case insensitive</strong> and <strong>remove</strong> the count from the <strong>current ASCII value of each symbol</strong> of the encrypted message.</p>
<p>After decryption:</p>
<p>Each message should have a<strong> planet name, population, attack type ('A', as attack or 'D', as destruction) and soldier count.</strong></p>
<p>The planet name <strong>starts after</strong> <strong>'@'</strong> and contains <strong>only letters from the Latin alphabet</strong>.</p>
<p>The planet population <strong>starts after ':'</strong> and is an<strong> Integer</strong>;</p>
<p>The attack type may be <strong>"A"(attack) or "D"(destruction)</strong> and must be <strong>surrounded by "!" </strong>(exclamation mark).</p>
<p>The <strong>soldier count </strong>starts after <strong>"-&gt;"</strong> and should be an Integer.</p>
<p>The order in the message should be: <strong>planet name -&gt; planet population -&gt; attack type -&gt; soldier count. </strong>Each part can be separated from the others by<strong> any character except: '@', '-', '!', ':' and '&gt;'.</strong></p>
<h2>Input / Constraints</h2>
<ul>
<li>The <strong>first line</strong> <strong>holds n</strong> &ndash; the number of <strong>messages</strong>&ndash; <strong>integer in range [1&hellip;100];</strong></li>
<li>On the next <strong>n</strong> lines, you will be receiving encrypted messages.</li>
</ul>
<h2>Output</h2>
<p>After decrypting all messages, you should print the decrypted information in the following format:</p>
<p>First print the attacked planets, then the destroyed planets.<br /> "Attacked planets: {attackedPlanetsCount}"<br /> "-&gt; {planetName}"<br /> "Destroyed planets: {destroyedPlanetsCount}"<br /> "-&gt; {planetName}"</p>
<p>The planets should be <strong>ordered by name</strong> <strong>alphabetically.</strong></p>
<h2>Examples</h2>
<table width="1404">
<tbody>
<tr>
<td width="491">
<p><strong>Input</strong></p>
</td>
<td width="384">
<p><strong>Output</strong></p>
</td>
<td width="529">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="491">
<p>2</p>
<p><strong>ST</strong>CDoghudd4=63333$D$0<strong>A</strong>53333</p>
<p>EHf<strong>s</strong>y<strong>ts</strong>nhf?8555&amp;I&amp;2C9555<strong>SR</strong></p>
</td>
<td width="384">
<p>Attacked planets: 1</p>
<p>-&gt; Alderaa</p>
<p>Destroyed planets: 1</p>
<p>-&gt; Cantonica</p>
</td>
<td width="529">
<p>We receive two messages, to decrypt them we calculate the key:</p>
<p>First message has decryption key 3. So we substract from each characters code 3.</p>
<p><strong>PQ@Alderaa1:30000!A!-&gt;</strong><strong>20000</strong></p>
<p>The second message has key 5.</p>
<p><strong>@Cantonica:3000!D!-&gt;4000NM</strong></p>
<p><strong>Both messages are valid</strong> and they contain planet, population, attack type and soldiers count.</p>
<p>After decrypting all messages we print each planet according the format given.</p>
</td>
</tr>
<tr>
<td width="491">
<p><strong>Input</strong></p>
</td>
<td width="384">
<p><strong>Output</strong></p>
</td>
<td width="529">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="491">
<p>3</p>
<p><strong>tt</strong>(''DG<strong>s</strong>vywge<strong>r</strong>x&gt;6444444444%H%1B9444</p>
<p>GQh<strong>rr</strong>|<strong>A</strong>977777(H(<strong>TTTT</strong></p>
<p>EHf<strong>s</strong>y<strong>ts</strong>nhf?8555&amp;I&amp;2C9555<strong>SR</strong></p>
</td>
<td width="384">
<p>Attacked planets: 0</p>
<p>Destroyed planets: 2</p>
<p>-&gt; Cantonica</p>
<p>-&gt; Coruscant</p>
</td>
<td width="529">
<p>We receive three messages.</p>
<p>Message one is decrypted with key 4:</p>
<p><strong>pp$##@Coruscant:2000000000!D!-&gt;5000</strong></p>
<p>Message two is decrypted with key 7:</p>
<p><strong>@Jakku:200000!A!MMMM</strong></p>
<p>This is <strong>invalid message</strong>, missing soldier count, so we continue.</p>
<p>The third message has key 5.</p>
<p><strong>@Cantonica:3000!D!-&gt;4000NM</strong></p>
</td>
</tr>
</tbody>
</table>
<h2>&nbsp;</h2>
<p>"It&rsquo;s a trap!" &ndash; Admiral Ackbar</p>

<h1>Problem 4. ForceBook</h1>
<p>The force users are struggling to remember which side are the different forceUsers from, because they switch them too often. So you are tasked to create a web application to manage their profiles. You should store information for every <strong>unique forceUser</strong>, registered in the application.</p>
<p>You will receive <strong>several input lines</strong> in one of the following formats:</p>
<p>{forceSide} | {forceUser}</p>
<p>{forceUser} -&gt; {forceSide}</p>
<p>The forceUser and forceSide are strings, containing any character.</p>
<p>If you receive forceSide | forceUser you should <strong>check if such forceUser already exists</strong>, and <strong>if not</strong>, <strong>add</strong> him/her to the corresponding side.</p>
<p>If you receive a forceUser -&gt; forceSide you should check if there is such <strong>forceUser</strong> already and if so, <strong>change his/her side</strong>. If there is no such <strong>forceUser</strong>, add him/her to the corresponding forceSide, treating the command <strong>as new registered forceUser.</strong><br /> Then you should print on the console: "{forceUser} joins the {forceSide} side!"</p>
<p>You should end your program when you receive the command "Lumpawaroo". At that point you should print each force side, <strong>ordered descending by </strong><strong>forceUsers count, than ordered by name</strong>. For each side print the <strong>forceUsers</strong>, <strong>ordered by name</strong>.</p>
<p>In case there are <strong>no forceUsers in a side</strong>, you <strong>shouldn`t print</strong> the side information. <br /> </p>
<h2>Input / Constraints</h2>
<ul>
<li>The input comes in the form of commands in one of the formats specified above.</li>
<li>The input ends when you receive the command "Lumpawaroo".<br /> </li>
</ul>
<h2>Output</h2>
<ul>
<li>As output for each forceSide, <strong>ordered descending by forceUsers count</strong>, <strong>then by name</strong>, you must print all the forceUsers, <strong>ordered by name alphabetically</strong>.</li>
<li>The output format is:</li>
</ul>
<p>Side: {forceSide}, Members: {forceUsers.Count}</p>
<p>! {forceUser}</p>
<p>! {forceUser}</p>
<p>! {forceUser}</p>
<ul>
<li>In case there are <strong>NO</strong> forceUsers, don`t print this side. <br /> </li>
</ul>
<h2>Examples</h2>
<table width="1352">
<tbody>
<tr>
<td width="380">
<p><strong>Input</strong></p>
</td>
<td width="600">
<p><strong>Output</strong></p>
</td>
<td width="372">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="380">
<p>Light | Gosho</p>
<p>Dark | Pesho</p>
<p>Lumpawaroo</p>
</td>
<td width="600">
<p>Side: Dark, Members: 1</p>
<p>! Pesho</p>
<p>Side: Light, Members: 1</p>
<p>! Gosho</p>
</td>
<td width="372">
<p>We register Gosho in the Light side and Pesho in the Dark side. After receiving "Lumpawaroo" we print both sides, ordered by membersCount and then by name.</p>
</td>
</tr>
<tr>
<td width="380">
<p><strong>Input</strong></p>
</td>
<td width="600">
<p><strong>Output</strong></p>
</td>
<td width="372">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="380">
<p>Lighter | Royal</p>
<p>Darker | DCay</p>
<p>Ivan Ivanov -&gt; Lighter</p>
<p>DCay -&gt; Lighter</p>
<p>Lumpawaroo</p>
</td>
<td width="600">
<p>Ivan Ivanov joins the Lighter side!</p>
<p>DCay joins the Lighter side!</p>
<p>Side: Lighter, Members: 3</p>
<p>! DCay</p>
<p>! Ivan Ivanov</p>
<p>! Royal</p>
<p>&nbsp;</p>
</td>
<td width="372">
<p>Although Ivan Ivanov doesn`t have profile, we <strong>register</strong> him and add him to the Lighter side.</p>
<p>We <strong>remove DCay</strong> from Darker side and add him to Lighter side.</p>
<p>We print only Lighter side because Darker side <strong>has no members.</strong></p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>"I find your lack of faith disturbing." &mdash; Darth Vader</p>