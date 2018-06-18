<h1>Problem 1 &ndash; Snowballs</h1>
<p>Tony and Andi love playing in the snow and having snowball fights, but they always argue which makes the best snowballs. Because they are girls (which means they are completely illogical), they have decided to involve you in their fray, by making you write a program which calculates snowball data, and outputs the best snowball value.</p>
<p>You will receive N &ndash; an <strong>integer</strong>, the <strong>number</strong> of <strong>snowballs</strong> being made by Tony and Andi.<br /> <strong>For each snowball</strong> you will receive <strong>3 input lines</strong>:</p>
<ul>
<li>On the <strong>first line</strong> you will get the snowballSnow &ndash; an <strong>integer</strong>.</li>
<li>On the <strong>second line</strong> you will get the snowballTime &ndash; an <strong>integer</strong>.</li>
<li>On the <strong>third line</strong> you will get the snowballQuality &ndash; an <strong>integer</strong>.</li>
</ul>
<p><strong>For each snowball</strong> you must <strong>calculate</strong> its snowballValue by the following formula:</p>
<p>(snowballSnow / snowballTime) ^ snowballQuality</p>
<p>At the end you must print the <strong>highest</strong> calculated snowballValue.</p>
<h2>Input</h2>
<ul>
<li>On the <strong>first input line</strong> you will receive <strong>N</strong> &ndash; the <strong>number</strong> of <strong>snowballs</strong>.</li>
<li>On the <strong>next N * 3 input lines</strong> you will be receiving <strong>data</strong> about <strong>snowballs</strong>.</li>
</ul>
<h2>Output</h2>
<ul>
<li>As output you must print the <strong>highest</strong> calculated snowballValue, by the formula, <strong>specified above</strong>.</li>
<li>The output format is: <br /> {snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})</li>
</ul>
<h2>Constraints</h2>
<ul>
<li>The<strong> number </strong>of<strong> snowballs</strong> (N) will be an <strong>integer</strong> in <strong>range [0, 100]</strong>.</li>
<li>The snowballSnow is an <strong>integer</strong> in <strong>range [0, 1000]</strong>.</li>
<li>The snowballTime is an <strong>integer</strong> in <strong>range [</strong><strong>1, 500]</strong>.</li>
<li>The snowballQuality is an <strong>integer</strong> in <strong>range [0, 100]</strong>.</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table>
<tbody>
<tr>
<td width="142">
<p><strong>Input</strong></p>
</td>
<td width="311">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="142">
<p>2</p>
<p>10</p>
<p>2</p>
<p>3</p>
<p>5</p>
<p>5</p>
<p>5</p>
</td>
<td width="311">
<p>10 : 2 = 125 (3)</p>
</td>
</tr>
<tr>
<td width="142">
<p>3</p>
<p>10</p>
<p>5</p>
<p>7</p>
<p>16</p>
<p>4</p>
<p>2</p>
<p>20</p>
<p>2</p>
<p>2</p>
</td>
<td width="311">
<p>10 : 5 = 128 (7)</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>


<h1>Problem 2 &ndash; Snowmen</h1>
<p>The Snowmen Fray has been on since the dawn of time. Professor Olaf is currently studying the ancient war methods, and needs you to write a program that simulates a battle between snowmen.</p>
<p>You will receive a <strong>sequence</strong> of <strong>integers</strong>, <strong>separated</strong> by <strong>spaces</strong> &ndash; the <strong>snowmen</strong>, <br /> which are <strong>indexed</strong> from <strong>0</strong> &ndash; <strong>sequence.length &ndash; 1</strong>.</p>
<p>You must <strong>traverse the elements</strong>, from the <strong>first</strong> till the <strong>last</strong>. Each element is an <strong>attacker index</strong>, and its <strong>integer value</strong> is its <strong>target index</strong>. If the <strong>integer value</strong> is <strong>greater than</strong> the <strong>length</strong> of the <strong>sequence</strong>, <strong>divide</strong> it <strong>modulo</strong> (<strong>%</strong>) by the length of the sequence. <strong>Example</strong>: <strong>target</strong> = <strong>12</strong>, <strong>length</strong> = <strong>7</strong>, <strong>target</strong> = <strong>12 % 7</strong> - &gt; <strong>5</strong>.</p>
<p>When you extract <strong>attacker index</strong> and the <strong>target index</strong>, you must calculate the <strong>absolute value</strong> of the <strong>difference</strong> between them.</p>
<ul>
<li>If the <strong>difference</strong> is an <strong>even number</strong>, the <strong>attacker wins</strong>.</li>
<li>if the <strong>difference</strong> is an <strong>odd number</strong>, the <strong>target wins</strong>.</li>
<li>If the <strong>attacker</strong> and the <strong>target</strong> are <strong>equal</strong> (they are <strong>the same indexes</strong>), that means that snowman <strong>suicides</strong>.</li>
</ul>
<p>If an element <strong>loses</strong> a battle or <strong>suicides</strong>, it <strong>should NOT be able</strong> to <strong>attack</strong>. It <strong>can</strong> still be a <strong>target</strong> though.</p>
<p>When you finish traversing the whole sequence, you must <strong>remove all elements</strong> that have <strong>lost</strong> or <strong>suicided</strong>, and then you must <strong>start over</strong>. The process must be <strong>repeated</strong> until there is <strong>1</strong> <strong>snowman left </strong>in the <strong>sequence</strong>.</p>
<p>For each <strong>attacker</strong> and <strong>target</strong>, you must print &ldquo;{attacker} x {target} -&gt; {winner} wins&rdquo;. <br /> The <strong>attacker</strong> and the <strong>target</strong> are <strong>indexes</strong>, and the winner is the <strong>index</strong> of the <strong>winner</strong>.</p>
<p>In that case you must print &ldquo;{attacker} performed harakiri&rdquo;.</p>
<h2>Input</h2>
<ul>
<li>As input you will receive a <strong>single input line</strong> containing the <strong>sequence</strong> of <strong>integers</strong>, <strong>separated</strong> by <strong>spaces</strong>.</li>
</ul>
<h2>Output</h2>
<ul>
<li>As output you must print each action between attacker and target, in the formats specified above.</li>
</ul>
<h2>Constraints</h2>
<ul>
<li>The <strong>elements</strong> of the <strong>sequence</strong> will be <strong>between 0</strong> and <strong>100</strong>.</li>
<li>The <strong>integers</strong> in the <strong>sequence</strong> will be in <strong>range [0, 1000]</strong>.</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table width="1474">
<tbody>
<tr>
<td width="287">
<p><strong>Input</strong></p>
</td>
<td width="368">
<p><strong>Output</strong></p>
</td>
<td width="820">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="287">
<p>4 3 2 1 0</p>
</td>
<td width="368">
<p>0 x 4 -&gt; 0 wins</p>
<p>1 x 3 -&gt; 1 wins</p>
<p>2 performed harakiri</p>
<p>0 performed harakiri</p>
</td>
<td width="820">
<p>First: Attacker &ndash; 0, Target &ndash; 4. Difference = 4 (even) Attacker wins, Target lost.<br /> Second: Attacker &ndash; 1, Target &ndash; 3. Difference = 2 (even) Attacker wins, Target lost.<br /> Third: Attacker &ndash; 2, Target &ndash; 2. Equal, Attacker suicided.<br /> All other elements have lost. We remove them from the sequence. Sequence &ndash; 4 3. Length = 2.<br /> First: Attacker &ndash; 0, Target &ndash; 4 (% 2) = 0. Equal, Attacker suicided.</p>
<p>There is 1 element left, we stop the program.<br /> </p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="287">
<p>25 31 6 9 2 4 7</p>
</td>
<td width="368">
<p>0 x 4 -&gt; 0 wins</p>
<p>1 x 3 -&gt; 1 wins</p>
<p>2 x 6 -&gt; 2 wins</p>
<p>5 x 4 -&gt; 4 wins</p>
<p>0 x 1 -&gt; 1 wins</p>
<p>1 performed harakiri</p>
</td>
<td width="820">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>


<h1>Problem 3 &ndash; Snowflake</h1>
<p>Tony and Andi have been researching the snowflake structure for quite some time now. They managed to write a program which extracts a text pattern from the snowflake, but it oftenly produces invalid data. They begged you to help them, so you must write a program which validates the text pattern.</p>
<p>The <strong>snowflake</strong> has <strong>3 elements</strong>:</p>
<ul>
<li><strong>Surface</strong> &ndash; should <strong>NOT</strong> contain <strong>letters</strong> and <strong>digits</strong>.</li>
<li><strong>Mantle</strong> &ndash; should <strong>ONLY</strong> contain <strong>digits</strong> and <strong>underscores</strong> (&ldquo;_&rdquo;).</li>
<li><strong>Core</strong> &ndash; should <strong>ONLY</strong> contain <strong>letters</strong>.</li>
</ul>
<p>You will receive several input lines, which will represent the <strong>snowflake</strong>. A <strong>valid</strong> snowflake is in the following format:</p>
<p>{surface}<br /> {mantle}<br /> {surface}{mantle}{core}{mantle}{surface}<br /> {mantle}<br /> {surface}</p>
<p>You must check if <strong>all elements</strong> are <strong>valid</strong>, by the <strong>rules specified above</strong>. If even one element is invalid, you should print &ldquo;<strong>Invalid</strong>&rdquo;.</p>
<p>If all are valid you should print &ldquo;<strong>Valid</strong>&rdquo; and the <strong>length</strong> of the core part on the <strong>next line</strong>.</p>
<h2>Input</h2>
<ul>
<li>The input will consist of exactly <strong>5 input lines</strong>, in the format <strong>specified above</strong>.</li>
</ul>
<h2>Output</h2>
<ul>
<li>If <strong>all the elements</strong> of the <strong>snowflake</strong> are <strong>valid</strong>, you must print &ldquo;<strong>Valid</strong>&rdquo;, and the <strong>length</strong> of the <strong>core</strong>.</li>
<li>If <strong>even one</strong> of the <strong>elements</strong> is <strong>invalid</strong>, you must print &ldquo;<strong>Invalid</strong>&rdquo;.</li>
</ul>
<h2>Constraints</h2>
<ul>
<li>The elements of the input may contain <strong>ANY ASCII character</strong>.</li>
<li>The <strong>input</strong> will <strong>always consist</strong> of <strong>5 input lines</strong>.</li>
<li>The input <strong>may not always</strong> be in the <strong>valid snowflake</strong> <strong>format</strong>.</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table>
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>*-*</p>
<p>1_1_1</p>
<p>***444asd444***</p>
<p>1_1_1</p>
<p>*-*</p>
</td>
<td width="695">
<p>Valid</p>
<p>3</p>
</td>
</tr>
<tr>
<td width="695">
<p>!!!!!!</p>
<p>14741</p>
<p>-2Asdasdasdasd555!</p>
<p>___</p>
<p>--</p>
</td>
<td width="695">
<p>Valid</p>
<p>12</p>
</td>
</tr>
<tr>
<td width="695">
<p>Asd</p>
<p>Asd</p>
<p>Asd</p>
<p>Asd</p>
<p>asd</p>
<p>&nbsp;</p>
</td>
<td width="695">
<p>Invalid</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>


<h1>Problem 4 &ndash; Snowwhite</h1>
<p>Snow White loves her dwarfs, but there are so many and she doesn&rsquo;t know how to order them. Does she order them by name? Or by color of their hat? Or by physics? She can&rsquo;t decide, so its up to you to write a program that does it for her.</p>
<p>You will be receiving <strong>several input lines</strong> which contain <strong>data</strong> about <strong>dwarfs</strong> in the following format:</p>
<p>{dwarfName} &lt;:&gt; {dwarfHatColor} &lt;:&gt; {dwarfPhysics}</p>
<p>The dwarfName and the dwarfHatColor are <strong>strings</strong>. The dwarfPhysics is an <strong>integer</strong>.</p>
<p>You must <strong>store</strong> the <strong>dwarfs</strong> in your program. There are several rules though:</p>
<ul>
<li>If <strong>2 dwarfs</strong> have the <strong>same name</strong> but <strong>different color</strong>, they should be <strong>considered different dwarfs</strong>, and you should store <strong>both</strong> of them.</li>
<li>If <strong>2 dwarfs</strong> have the <strong>same name</strong> and the <strong>same color</strong>, <strong>store </strong>the <strong>one</strong> with the <strong>higher physics</strong>.</li>
</ul>
<p>When you receive the command &ldquo;Once upon a time&rdquo;, the input ends. You must <strong>order</strong> the <strong>dwarfs</strong> by <strong>physics </strong>in <strong>descending order</strong> and then by <strong>total</strong> <strong>count </strong>of<strong> dwarfs</strong> with the <strong>same hat color</strong> in <strong>descending order</strong>. <br /> Then you must print them all.</p>
<h2>Input</h2>
<ul>
<li>The input will consists of <strong>several input lines</strong>, containing <strong>dwarf data</strong> in the format, specified above.</li>
<li>The input <strong>ends</strong> when you receive the command &ldquo;Once upon a time&rdquo;.</li>
</ul>
<h2>Output</h2>
<ul>
<li>As output you must print the <strong>dwarfs</strong>, <strong>ordered</strong> in the way , specified above.</li>
<li>The output format is: ({hatColor}) {name} &lt;-&gt; {physics}</li>
</ul>
<h2>Constraints</h2>
<ul>
<li>The dwarfName will be a <strong>string</strong> which may contain <strong>any ASCII</strong> character except &lsquo; &rsquo; (space), &lsquo;&lt;&rsquo;, &lsquo;:&rsquo;, &lsquo;&gt;&rsquo;.</li>
<li>The dwarfHatColor will be a <strong>string</strong> which may contain <strong>any ASCII</strong> character except &lsquo; &rsquo; (space), &lsquo;&lt;&rsquo;, &lsquo;:&rsquo;, &lsquo;&gt;&rsquo;.</li>
<li>The dwarfPhysics will be an <strong>integer</strong> in <strong>range [0, 2<sup>31</sup> &ndash; 1]</strong>.</li>
<li>There will be <strong>no invalid</strong> input lines.</li>
<li>If <strong>all sorting criteria fail</strong>, the order should be by <strong>order</strong> of <strong>input</strong>.</li>
<li>Allowed working <strong>time</strong> / <strong>memory</strong>: <strong>100ms</strong> / <strong>16MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table>
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Pesho &lt;:&gt; Red &lt;:&gt; 2000</p>
<p>Tosho &lt;:&gt; Blue &lt;:&gt; 1000</p>
<p>Gosho &lt;:&gt; Green &lt;:&gt; 1000</p>
<p>Sasho &lt;:&gt; Yellow &lt;:&gt; 4500</p>
<p>Prakasho &lt;:&gt; Stamat &lt;:&gt; 1000</p>
<p>Once upon a time</p>
</td>
<td width="695">
<p>(Yellow) Sasho &lt;-&gt; 4500</p>
<p>(Red) Pesho &lt;-&gt; 2000</p>
<p>(Blue) Tosho &lt;-&gt; 1000</p>
<p>(Green) Gosho &lt;-&gt; 1000</p>
<p>(Stamat) Prakasho &lt;-&gt; 1000</p>
</td>
</tr>
<tr>
<td width="695">
<p>Pesho &lt;:&gt; Red &lt;:&gt; 5000</p>
<p>Pesho &lt;:&gt; Blue &lt;:&gt; 10000</p>
<p>Pesho &lt;:&gt; Red &lt;:&gt; 10000</p>
<p>Gosho &lt;:&gt; Blue &lt;:&gt; 10000</p>
<p>Once upon a time</p>
</td>
<td width="695">
<p>(Blue) Pesho &lt;-&gt; 10000</p>
<p>(Blue) Gosho &lt;-&gt; 10000</p>
<p>(Red) Pesho &lt;-&gt; 10000</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>