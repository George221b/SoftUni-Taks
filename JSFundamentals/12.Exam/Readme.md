<h1>Problem 1 &ndash; Bitcoin "Mining"</h1>
<p><em>So you have heard that a lot of people are using Bitcoins as alternative currency and mining them can make you rich quickly, without doing </em><em>anything. Because of this you decided to become a miner at the local mine and start digging Bitcoins out of the ground. Well, after a few days you realized that there are no burried Bitcoins in the ground... But luckily, you started digging up gold and decided to invest it in Bitcoins, because they are cool and gold sucks. So you started exchanging gold for BGN and buying Bitcoins with the money, and keeping track of the whole process. How many Bitcoins did you buy and how much money were you left with it at the end?</em></p>
<p>Write a JavaScript program that calculates the <strong>total amount</strong> of <strong>bitcoins</strong> you purchased with the gold you mined during your <strong>shift </strong>at the mine. Your shift consists of a certain number of days where you mine an amount of <strong>gold</strong> in <strong>grams</strong>. Your program will receive an <strong>array with the amount of gold </strong>you mined <strong>each day</strong>, where the <strong>first day</strong> of your <strong>shift</strong> is the <strong>first index of the array</strong>. Also, someone was stealing <strong>every third day</strong> from the start of your shift <strong>30%</strong> from the mined <strong>gold</strong> for <strong>this day</strong>. For the different exchanges use these <strong>prices</strong>:</p>
<table>
<tbody>
<tr>
<td width="233">
<p><strong>1 Bitcoin</strong></p>
</td>
<td width="189">
<p>11949.16 lv.</p>
</td>
</tr>
<tr>
<td width="233">
<p><strong>1 g of gold</strong></p>
</td>
<td width="189">
<p>67.51 lv.</p>
</td>
</tr>
</tbody>
</table>
<h3>Input</h3>
<p>You will receive an array of <strong>strings</strong> that must be parsed as <strong>numbers</strong>, representing your <strong>shift </strong>at the mine.</p>
<h3>Output</h3>
<p>Print on the <strong>console these lines in the following formats</strong>:</p>
<ul>
<li><strong>First line</strong> prints the <strong>total</strong> <strong>amount </strong>of bought <strong>bitcoins</strong>:</li>
</ul>
<p>&nbsp;"<strong>Bought Bitcoins: {count}</strong>"</p>
<ul>
<li><strong>Second line</strong> prints <strong>witch day</strong> you <strong>bought</strong> your <strong>first bitcoin</strong>:</li>
</ul>
<p>&nbsp;"<strong>Day of the first purchased bitcoin: {day}</strong>"</p>
<p>In case you <strong>did not</strong> <strong>purchased any bitcoins,</strong> do not print the second line.</p>
<ul>
<li><strong>Third line</strong> prints the <strong>amount</strong> of <strong>money</strong> that&rsquo;s left after the bitcoin purchases <strong>rounded by the second digit</strong> after the decimal point:</li>
</ul>
<p>&nbsp;"<strong>Left money: {money} lv.</strong>"</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>input</strong> array may contain up to <strong>1,000</strong> elements</li>
<li>The numbers in the array are in range <strong>[0.01..5,000.00] inclusive</strong></li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<h3>&nbsp;Examples</h3>
<table width="979">
<tbody>
<tr>
<td width="280">
<p><strong>Input</strong></p>
</td>
<td width="699">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="280">
<p>100, 200, 300</p>
</td>
<td width="699">
<p>Bought Bitcoins: 2</p>
<p>Day of the first purchased bitcoin: 2</p>
<p>Left money: 10531.78 lv.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>Scroll down to see the explanation for the first example and more examples.</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Day 1</strong> &ndash; you dig up <strong>100 g</strong> of gold then exchange it for <strong>6751.00 lv.</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>Day 2 </strong>&ndash; you dig up <strong>200 g</strong> of gold then exchange it for <strong>13,502.00 lv. </strong>and the total amount of money is <strong>20,253.00 lv. </strong>Then you buy <strong>1 Bitcoin </strong>which leaves you with <strong>8,303.84 lv. </strong>Also this purchase is the <strong>first day you bought bitcoin</strong>.</p>
<p>&nbsp;</p>
<p><strong>Day 3 </strong>&ndash; you dig up <strong>300 g </strong>of gold but then <strong>30% </strong>of it is stolen and your gold drops to <strong>210 g </strong>which you exchange for <strong>14,177.10 lv. </strong>making your total amount of money <strong>22,480.94 lv. </strong>Then you buy <strong>1 </strong><strong>Bitcoin </strong>making the final amount of money that you are <strong>left with</strong> <strong>10,531.78 lv. </strong>with <strong>2 bought Bitcoins.</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="91">
<p><strong>Input</strong></p>
</td>
<td width="416">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="76">
<p><strong>&nbsp;</strong></p>
</td>
<td width="170">
<p><strong>Input</strong></p>
</td>
<td width="639">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="91">
<p>50, 100</p>
</td>
<td width="416">
<p>Bitcoins bought: 0</p>
<p>Money left: 10126.50 lv.</p>
</td>
<td width="170">
<p>3124.15, 504.212, 2511.124</p>
</td>
<td width="639">
<p>Bitcoins bought: 30</p>
<p>Day of the first purchased bitcoin: 1</p>
<p>Money left: 5144.11 lv.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>


<h1>Problem 2 &ndash; Air Pollution</h1>
<p><em>Because of recent events you have become very conscious of the air quality in Sofia. That&rsquo;s why you decided to keep track of the air pollution levels by making a map. Each block of the map displays a number that represents the current particle pollution in the air at this moment. There are different forces which affect the air quality in various ways. So how clean is the air in Sofia now?</em></p>
<p>Write a JavaScript program that tracks the<strong> pollution</strong> <strong>in the air</strong> above Sofia. You will receive <strong>two arguments</strong> &ndash; the <strong>first</strong> is the <strong>map of Sofia</strong> represented by a <strong>matrix of numbers</strong> and the second is an <strong>array of strings</strong> representing the <strong>forces</strong> <strong>affecting</strong> the <strong>air quality</strong>. The <strong>map</strong> will <strong>always</strong> be with <strong>5 rows</strong> and <strong>5 columns</strong> in <strong>total</strong> <strong>of</strong> <strong>25 elements - blocks</strong>. Each block&rsquo;s particle pollution (PM) is <strong>affected</strong> by <strong>3 forces </strong>received in the following formats<strong>:</strong></p>
<ul>
<li><strong>"</strong><strong>breeze {index}"</strong><strong> &ndash;</strong> index is <strong>the row </strong>where <strong>all column&rsquo;s value drops </strong>by <strong>15 </strong>PM</li>
<li><strong>"</strong><strong>gale {index}"</strong><strong> &ndash; </strong>index is <strong>the column in all rows </strong>where <strong>value drops </strong>by <strong>20 </strong>PM</li>
<li><strong>"</strong><strong>smog {value}"</strong><strong> &ndash; all</strong> <strong>blocks </strong>in the map <strong>increase</strong> equally by <strong>the given value&rsquo;s </strong>PM</li>
</ul>
<p>The threshold in each block is <strong>50 </strong>PM. If it is <strong>below</strong> <strong>that number</strong>, the block&rsquo;s air is considered <strong>normal</strong> but if it <strong>reaches or goes over it,</strong> that block&rsquo;s air is considered <strong>polluted</strong>. Also note, that the <strong>polluted particles</strong> in a block <strong>cannot go below</strong> <strong>zero</strong>.</p>
<p>Finally, your program needs to <strong>find</strong> if there are <strong>any polluted blocks</strong> and <strong>print them </strong>in the format given below.</p>
<h3>Input</h3>
<p>You will receive <strong>two</strong> <strong>arguments</strong>:</p>
<ul>
<li>The<strong> first</strong> argument is an <strong>array with five strings</strong> &ndash; <strong>rows</strong> of the matrix with <strong>columns separated by space </strong>that must be parsed as <strong>numbers</strong>, representing the <strong>map of Sofia</strong>.</li>
<li>The <strong>second</strong> argument is an <strong>array of strings</strong> &ndash; each <strong>string</strong> consists of one of the <strong>words (breeze/gale/smog)</strong> and a <strong>number</strong> <strong>separated by space</strong>, representing the <strong>different forces</strong>.</li>
</ul>
<h3>Output</h3>
<p>Print on the <strong>console</strong><strong> a </strong><strong>single line</strong>:</p>
<ul>
<li>If there are <strong>polluted blocks</strong> in the map, <strong>use</strong> their <strong>coordinates</strong> in the following format:</li>
<li><strong>"[{rowIndex}-{columnIndex}]"</strong></li>
</ul>
<p>Note that you must <strong>start</strong> from the <strong>top left corner</strong> of the map moving to the <strong>bottom right corner</strong> <strong>horizontally</strong>. Then <strong>separate</strong> each <strong>formatted block&rsquo;s coordinates</strong> with <strong>comma and space</strong> and print them in a single line in the following format:</p>
<ul>
<li><strong>"Polluted areas: {block1}, {block2}, {block3}, &hellip;"</strong></li>
<li>If there are <strong>no polluted blocks</strong> in the map print:</li>
<li><strong>"No polluted areas"</strong></li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The <strong>number</strong> of <strong>rows</strong> and <strong>columns</strong> for the <strong>matrix </strong>will<strong> always </strong>be <strong>5</strong></li>
<li>The <strong>number</strong> in each block will be an <strong>integer</strong> in range <strong>[0..1000] inclusive</strong></li>
<li>The <strong>number</strong> of <strong>elements</strong> in the <strong>second input argument</strong> will be in range <strong>[0..100] inclusive</strong></li>
<li>Given <strong>smog&rsquo;s</strong> <strong>value </strong>will be an <strong>integer </strong>in range <strong>[0..100] inclusive</strong></li>
<li>Given <strong>indexes</strong> will <strong>always</strong> be <strong>valid</strong></li>
</ul>
<h3>Examples</h3>
<table width="1395">
<tbody>
<tr>
<td width="563">
<p><strong>Input</strong></p>
</td>
<td width="832">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="563">
<p>[</p>
<p>&nbsp; "5 7 72 14 4",</p>
<p>&nbsp; "41 35 37 27 33",</p>
<p>&nbsp; "23 16 27 42 12",</p>
<p>&nbsp; "2 20 28 39 14",</p>
<p>&nbsp; "16 34 31 10 24",</p>
<p>],</p>
<p>["breeze 1", "gale 2", "smog 25"]</p>
</td>
<td width="832">
<p>Polluted areas: [0-2], [1-0], [2-3], [3-3], [4-1]</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<h3>Explanation</h3>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>input</strong></p>
</td>
</tr>
</tbody>
</table>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>breeze 1 (-15)</strong></p>
</td>
</tr>
</tbody>
</table>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>gale 2 (-20)</strong></p>
</td>
</tr>
</tbody>
</table>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>smog 25 (+25)</strong></p>
</td>
</tr>
</tbody>
</table>
<table width="100%">
<tbody>
<tr>
<td>
<p><strong>polluted areas</strong></p>
</td>
</tr>
</tbody>
</table>
<p>Graphic diagram explaining the <strong>first example&rsquo;s </strong>program flow:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;</p>
<table width="1395">
<tbody>
<tr>
<td width="563">
<p><strong>Input</strong></p>
</td>
<td width="832">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="563">
<p>[</p>
<p>&nbsp; "5 7 3 28 32",</p>
<p>&nbsp; "41 12 49 30 33",</p>
<p>&nbsp; "3 16 20 42 12",</p>
<p>&nbsp; "2 20 10 39 14",</p>
<p>&nbsp; "7 34 4 27 24",</p>
<p>],</p>
<p>[</p>
<p>&nbsp; "smog 11", "gale 3",</p>
<p>&nbsp; "breeze 1", "smog 2"</p>
<p>]</p>
</td>
<td width="832">
<p>No polluted areas</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1395">
<tbody>
<tr>
<td width="563">
<p><strong>Input</strong></p>
</td>
<td width="832">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="563">
<p>[</p>
<p>&nbsp; "5 7 2 14 4",</p>
<p>&nbsp; "21 14 2 5 3",</p>
<p>&nbsp; "3 16 7 42 12",</p>
<p>&nbsp; "2 20 8 39 14",</p>
<p>&nbsp; "7 34 1 10 24",</p>
<p>],</p>
<p>["breeze 1", "gale 2", "smog 35"]</p>
</td>
<td width="832">
<p>Polluted areas: [2-1], [2-3], [3-1], [3-3], [4-1], [4-4]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>

<h1>Problem 3 &ndash; Survey Parser</h1>
<p>Write a JavaScript program that <strong>parses</strong> a given <strong>document</strong> that may contain the results of a <strong>rating survey</strong> and outputs a <strong>summary</strong> of the votes. You will receive a <strong>string</strong> that contains XML-formatted data. From this data, you must extract a <strong>valid label</strong> and <strong>average rating</strong> (sum of ratings, divided by their count). Input, containing valid survey data will follow these rules:</p>
<ul>
<li>The document may contain <strong>any symbol</strong> <strong>before and after</strong> the survey data</li>
<li>The survey data <strong>always</strong> begins with &lt;svg&gt; and ends with &lt;/svg&gt;:</li>
</ul>
<p><em>&nbsp;Any text </em>&lt;svg&gt;<em> Survey data </em>&lt;/svg&gt;<em> Any text&nbsp;</em></p>
<ul>
<li>Each valid survey will contain <strong>exactly two</strong> <strong>sections</strong> beginning with &lt;cat&gt; and ending with &lt;/cat&gt;</li>
<li>There may be <strong>whitespace</strong> <strong>between</strong> the sections</li>
</ul>
<p>&lt;cat&gt;<em> Survey heading and label </em>&lt;/cat&gt;&lt;cat&gt;<em> Ratings </em>&lt;/cat&gt;</p>
<ul>
<li>The contents of the first cat section must begin with &lt;text&gt; and end with &lt;/text&gt;; it may contain <strong>any text</strong>, but needs to have a <strong>valid label</strong>, inside brackets []</li>
</ul>
<p>&lt;text&gt;<em> Survey heading </em>[<em> Survey Label </em>]&lt;/text&gt;</p>
<ul>
<li>The second cat section contains all of the <strong>ratings</strong> with each vote beginning with &lt;g&gt; and ending with &lt;/g&gt;</li>
<li>A <strong>valid rating</strong> contains a <strong>value</strong> and <strong>count</strong>, with the <strong>value</strong> surrounded by &lt;val&gt; and &lt;/val&gt; and the <strong>count</strong> right <strong>after the value</strong></li>
<li>There may be any number of <strong>valid</strong> and <strong>invalid ratings</strong> inside the second cat; you should <strong>only</strong> <strong>process</strong> the valid ones, and <strong>ignore</strong> the invalid ratings</li>
</ul>
<p>&lt;g&gt;&lt;val&gt;<em> Rating value </em>&lt;/val&gt;<em> Vote count </em>&lt;/g&gt;</p>
<ul>
<li><strong>Valid</strong> rating: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;g&gt;&lt;val&gt;1&lt;/val&gt;0&lt;/g&gt;</li>
<li><strong>Invalid</strong> rating (<strong>ignore</strong> and continue): &lt;g&gt;&lt;val&gt;Seafood&lt;/val&gt;1&lt;/g&gt;</li>
</ul>
<ul>
<li>The <strong>value</strong> must be a number between <strong>1</strong> and <strong>10</strong></li>
<li>The <strong>count</strong> must be a number <strong>0</strong> or larger</li>
</ul>
<p>If the document <strong>does not</strong> contain survey data (no opening and closing svg tags), print on the console "<strong>No survey found</strong>". If there is survey data, but the rest of the rules aren&rsquo;t followed, print on the console "<strong>Invalid format</strong>".</p>
<p>At the <strong>end</strong> of the program, print on the <strong>console</strong> the <strong>label</strong> of the survey and the <strong>average rating</strong>, <strong>rounded</strong> to two decimal places.</p>
<h3>Input</h3>
<p>You will receive a single <strong>string</strong>, containing a document to be parsed.</p>
<h3>Output</h3>
<p>Depending on outcome, print on the <strong>console </strong><strong>a single line</strong>:</p>
<ul>
<li><strong>No survey found</strong></li>
<li><strong>Invalid format</strong></li>
<li><strong>{label}: {average rating}</strong></li>
</ul>
<p><strong>&nbsp;</strong></p>
<h3>Constraints</h3>
<ul>
<li>There will never be more than one valid survey</li>
<li>Rating <strong>value</strong> will be in range <strong>[1&hellip;10]</strong></li>
<li>Rating <strong>count</strong> will be in range <strong>[1&hellip;1 000&nbsp;000]</strong></li>
</ul>
<h3>Examples</h3>
<table width="1391">
<tbody>
<tr>
<td width="280">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="280">
<p>&lt;p&gt;Some random text&lt;/p&gt;&lt;svg&gt;&lt;cat&gt;&lt;text&gt;How do you rate our food? [Food - General]&lt;/text&gt;&lt;/cat&gt;&lt;cat&gt;&lt;g&gt;&lt;val&gt;1&lt;/val&gt;0&lt;/g&gt;&lt;g&gt;&lt;val&gt;2&lt;/val&gt;1&lt;/g&gt;&lt;g&gt;&lt;val&gt;3&lt;/val&gt;3&lt;/g&gt;&lt;g&gt;&lt;val&gt;4&lt;/val&gt;10&lt;/g&gt;&lt;g&gt;&lt;val&gt;5&lt;/val&gt;7&lt;/g&gt;&lt;/cat&gt;&lt;/svg&gt;&lt;p&gt;Some more random text&lt;/p&gt;</p>
</td>
</tr>
<tr>
<td width="280">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="280">
<p>Food - General: 4.1</p>
</td>
</tr>
<tr>
<td width="280">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="280">
<p>The survey data is surrounded by &lt;svg&gt; and &lt;/svg&gt;, the remaing data is discarded. The first cat contains our label, surrounded by brackets: Food &ndash; General.</p>
<p>The second cat contains five ratings, all surrounded with &lt;g&gt; and &lt;/g&gt;, and when parsed we get the following:</p>
<p>0 votes with value 1 = 0</p>
<p>1 votes with value 2 = 2</p>
<p>3 votes with value 3 = 9</p>
<p>10 votes with value 4 = 40</p>
<p>7 votes with value 5 = 35</p>
<p>The sum of all ratings is 86, divided by their count 21 gives us the average rating <strong>4.095&hellip;</strong>, which we round to the second decimal &ndash; <strong>4.1</strong>.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;svg&gt;&lt;cat&gt;&lt;text&gt;How do you rate the special menu? [Food - Special]&lt;/text&gt;&lt;/cat&gt; &lt;cat&gt;&lt;g&gt;&lt;val&gt;1&lt;/val&gt;5&lt;/g&gt;&lt;g&gt;&lt;val&gt;5&lt;/val&gt;13&lt;/g&gt;&lt;g&gt;&lt;val&gt;10&lt;/val&gt;22&lt;/g&gt;&lt;/cat&gt;&lt;/svg&gt;</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Food - Special: 7.25</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="280">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="280">
<p>&lt;p&gt;How do you suggest we improve our service?&lt;/p&gt;&lt;p&gt;More tacos.&lt;/p&gt;&lt;p&gt;It's great, don't mess with it!&lt;/p&gt;&lt;p&gt;I'd like to have the option for delivery&lt;/p&gt;</p>
</td>
</tr>
<tr>
<td width="280">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="280">
<p>No survey found</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="280">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="280">
<p>&lt;svg&gt;&lt;cat&gt;&lt;text&gt;Which is your favourite meal from our selection?&lt;/text&gt;&lt;/cat&gt;&lt;cat&gt;&lt;g&gt;&lt;val&gt;Fish&lt;/val&gt;15&lt;/g&gt;&lt;g&gt;&lt;val&gt;Prawns&lt;/val&gt;31&lt;/g&gt;&lt;g&gt;&lt;val&gt;Crab Langoon&lt;/val&gt;12&lt;/g&gt;&lt;g&gt;&lt;val&gt;Calamari&lt;/val&gt;17&lt;/g&gt;&lt;/cat&gt;&lt;/svg&gt;</p>
</td>
</tr>
<tr>
<td width="280">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="280">
<p>Invalid format</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>


<h1>Problem 4 &ndash; Game of Epicness</h1>
<p><em>Welcome to the Game of Epicness where different kingdoms are fighting for the grant price of a bucket of Bitcoins&hellip; EPIC! In this amazing game there are many kingdoms with many generals and every general have their own army. To decide who is the winner for this totally amazing price they fight battles between them. But they are not so awesome at math, so they need you to help them record their battle results. </em></p>
<p>Write a JavaScript program that <strong>determines</strong> the <strong>winner</strong> from <strong>all battles</strong>. You will receive <strong>two</strong> arguments:</p>
<p>The <strong>first </strong>argument is an <strong>array of kingdoms </strong><strong>with</strong><strong> generals </strong><strong>and their</strong><strong> army</strong> in the form of an <strong>object</strong> with format:</p>
<p>{ kingdom: String, general: String, army: Number }</p>
<p>Every <strong>general</strong> has his own <strong>army</strong> that fights for a certain <strong>kingdom</strong>. Note that, every <strong>kingdom&rsquo;s name </strong>is <strong>unique, </strong>and every general&rsquo;s <strong>name </strong>is <strong>unique </strong>in <strong>this kingdom</strong>. If the <strong>general</strong> already <strong>exists</strong> <strong>in</strong> this <strong>kingdom</strong> <strong>add</strong> the <strong>army</strong> to his current one. After you go through all the kingdoms with their generals with armies and store the information about them, it&rsquo;s time to start the battles.</p>
<p>The <strong>second </strong>argument is <strong>matrix of strings </strong>showing which <strong>kingdom&rsquo;s generals</strong> are <strong>fighting</strong> in this format:</p>
<p><strong>[</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [ "{AttackingKingdom} ", "{AttackingGeneral}", "{DefendingKingdom} ", "{DefendingGeneral}" ],</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &hellip;</strong></p>
<p><strong>]</strong></p>
<p>The <strong>first two elements </strong>are the <strong>names </strong>of the <strong>attacking general from </strong>certain <strong>kingdom</strong> and the <strong>second two</strong> are the <strong>names</strong> of the <strong>defending general from </strong>certain <strong>kingdom</strong>. <strong>Compare</strong> the two general&rsquo;s <strong>armies to determine</strong> who <strong>wins</strong> and who <strong>losses </strong>based on who have the <strong>larger army wins. </strong>The <strong>winner&rsquo;s army increases </strong>with <strong>10% </strong>and the <strong>loser&rsquo;s army decreases </strong>with <strong>10%. </strong>Keep in mind to <strong>round</strong> them <strong>down</strong> if there is any excess <strong>army</strong> <strong>after the battle. </strong>If there is a <strong>draw</strong>, <strong>do not do anything</strong>.<strong> Keep track</strong> of the <strong>wins </strong>and <strong>losses</strong> for every general&rsquo;s battle.</p>
<p>Note that, <strong>generals</strong> from the <strong>same kingdom</strong> <strong>cannot</strong> <strong>attack</strong> <strong>each other</strong>.</p>
<p>After you finish with all battles you need to <strong>find</strong> which <strong>kingdom</strong> <strong>wins</strong> the game. To decide that, <strong>first</strong> <strong>order them </strong>by all their <strong>general&rsquo;s wins (descending)</strong> then by their <strong>losses (ascending), </strong>and finally by the <strong>kingdom&rsquo;s name </strong>in <strong>ascending alphabetical</strong> order.</p>
<h3>Input</h3>
<p>You will receive <strong>two arguments &ndash; </strong>an <strong>array of objects</strong> with properties and a <strong>matrix of strings</strong> as shown above.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> the winning kingdom and <strong>sort </strong>the generals by their <strong>armies in</strong> <strong>descending </strong>order,<strong> formatted </strong>as seen in the examples.</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>number</strong> of <strong>elements</strong> in the <strong>first input argument</strong> will be in range <strong>[1..100] inclusive</strong></li>
<li>The <strong>number</strong> of <strong>elements</strong> in the <strong>second input argument</strong> will be in range <strong>[0..100] inclusive</strong></li>
<li>General&rsquo;s <strong>army </strong>will be always an <strong>integer </strong>in range <strong>[0..1,000,000] inclusive</strong></li>
<li>There <strong>will</strong> be <strong>no invalid</strong> <strong>input</strong></li>
<li>There <strong>will </strong>be <strong>no matching number </strong>of <strong>armies </strong>in the <strong>output</strong></li>
</ul>
<h3>Examples</h3>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>[ { kingdom: "Maiden Way", general: "Merek", army: 5000 },</p>
<p>&nbsp; { kingdom: "Stonegate", general: "Ulric", army: 4900 },</p>
<p>&nbsp; { kingdom: "Stonegate", general: "Doran", army: 70000 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 0 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 2000 },</p>
<p>&nbsp; { kingdom: "Maiden Way", general: "Berinon", army: 100000 } ],</p>
<p>[ ["YorkenShire", "Quinn", "Stonegate", "Ulric"],</p>
<p>&nbsp; ["Stonegate", "Ulric", "Stonegate", "Doran"],</p>
<p>&nbsp; ["Stonegate", "Doran", "Maiden Way", "Merek"],</p>
<p>&nbsp; ["Stonegate", "Ulric", "Maiden Way", "Merek"],</p>
<p>&nbsp; ["Maiden Way", "Berinon", "Stonegate", "Ulric"] ]</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Winner: Stonegate</p>
<p>/\general: Doran</p>
<p>---army: 77000</p>
<p>---wins: 1</p>
<p>---losses: 0</p>
<p>/\general: Ulric</p>
<p>---army: 5336</p>
<p>---wins: 2</p>
<p>---losses: 1</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>After you successfully store the kingdoms information, the first battle&rsquo;s result is victory for the defender Ulric and a loss for the attacker Quinn. Second battle is ignored because the generals are from the same kingdom. Third battle is a victory for Doran and a loss for Merek. Fourth battle is a win for Ulric and a loss for Merek. Fifth battle is a victory for Berinon and a defeat for Ulric. All winners increase their armies with 10% for each win and all losers decrease their armies with 10% for each loss.</p>
<p>The result from the battles are &ndash; Stonegate: 3 wins and 1 loss; Maiden Way: 1 win and 2 losses; YorkenShire: 0 wins and 1 loss. Making Stonegate the winner of the games because they have the most wins from kingdoms.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>[ { kingdom: "Stonegate", general: "Ulric", army: 5000 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 5000 },</p>
<p>&nbsp; { kingdom: "Maiden Way", general: "Berinon", army: 1000 } ],</p>
<p>[ ["YorkenShire", "Quinn", "Stonegate", "Ulric"],</p>
<p>&nbsp; ["Maiden Way", "Berinon", "YorkenShire", "Quinn"] ]</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Winner: YorkenShire</p>
<p>/\general: Quinn</p>
<p>---army: 5500</p>
<p>---wins: 1</p>
<p>---losses: 0</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>The first battle between Quinn and Ulric is a draw because they have even armies because of that it is not recorded and their armies size does not change. The second battle is a win for Quinn and a loss for Berinon making YorkenShire the winner of the game with 1 win and 0 losses.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="1391">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>[ { kingdom: "Maiden Way", general: "Merek", army: 5000 },</p>
<p>&nbsp; { kingdom: "Stonegate", general: "Ulric", army: 4900 },</p>
<p>&nbsp; { kingdom: "Stonegate", general: "Doran", army: 70000 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 0 },</p>
<p>&nbsp; { kingdom: "YorkenShire", general: "Quinn", army: 2000 } ],</p>
<p>[ ["YorkenShire", "Quinn", "Stonegate", "Doran"],</p>
<p>&nbsp; ["Stonegate", "Ulric", "Maiden Way", "Merek"] ]</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Winner: Maiden Way</p>
<p>/\general: Merek</p>
<p>---army: 5500</p>
<p>---wins: 1</p>
<p>---losses: 0</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>