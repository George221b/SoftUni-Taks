<h1>Lab: Problem Solving</h1>
<p>This document defines the <strong>in-class exercise</strong> assignments for the <a href="https://softuni.bg/opencourses/algorithms">"Algorithms" course @ Software University</a>.</p>
<h1>1.&nbsp; Stars in the Cube</h1>
<p>We are given a <strong>cube of Latin letters</strong> of size <strong>n</strong> * <strong>n</strong> * <strong>n</strong> given as <strong>n</strong> layers (square matrices) of size <strong>n</strong> * <strong>n</strong>. A <strong>cube</strong>, split into <strong>layers</strong>, is shown on the <strong>right</strong> (each letter is shown as different color).</p>
<p>Write a program to calculate how many <strong>3D stars of 7 cells</strong> (center, up, down, left, right, front, back) holding <strong>equal letters</strong> exist in the cube.</p>
<p>The form of the <strong>3D star</strong> is shown at the figure on the <strong>left</strong>. The same letter can be shared between several stars (stars can overlap inside the cube).</p>
<h2>Inputs</h2>
<ul>
<li>The input is read from the console.</li>
<li>The first line holds an integer <strong>n</strong> &ndash; the size of the cube.</li>
<li>At the next <strong>n</strong> lines, the layers of the cube are given as sequence of <strong>n</strong> matrices separated by &lsquo;<strong>|</strong>&rsquo;.</li>
<li>The cells in each matrix row are separated by space (see the examples below).</li>
</ul>
<h2>Output</h2>
<ul>
<li>At the <strong>first line</strong> at the console print the <strong>total number of 3D stars</strong> of equal letters in the cube.</li>
<li>At the next few lines, for <strong>each letter</strong> in alphabetical order print the <strong>number of its stars</strong> found in the cube in format &ldquo;letter -&gt; count&rdquo;. Skip the letters that don&rsquo;t have any stars in the cube.</li>
</ul>
<h2>Constraints</h2>
<ul>
<li>The size of the cube <strong>n</strong> is integer in the range <strong>[1&hellip;75]</strong>.</li>
<li>All cube <strong>cells</strong> hold lowercase <strong>Latin letters</strong> in the range <strong>[&lsquo;a&rsquo;&hellip; &lsquo;z&rsquo;]</strong>.</li>
</ul>
<ul>
<li>Time limit: <strong>200 ms</strong>. Allowed memory: <strong>32</strong><strong> MB</strong>.</li>
</ul>
<h2>Examples</h2>
<table width="1115">
<tbody>
<tr>
<td width="958">
<p><strong>Input</strong></p>
</td>
<td width="157">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="958">
<p>5</p>
<p>a a a a a | a p a a a | a a a a a | a p a a a | p p p p p</p>
<p>a p a a a | p p p a a | a p a a a | p p p a a | p p p p p</p>
<p>a a a a a | a p x x a | a p a a a | p p p z a | p p p p p</p>
<p>a a x x a | a x x x x | a a x x a | a p z z z | p p p z p</p>
<p>a a a a a | a a x x a | a a a a a | a a a z a | p p p p p</p>
</td>
<td width="157">
<p>6</p>
<p>a -&gt; 1</p>
<p>p -&gt; 3</p>
<p>x -&gt; 2</p>
</td>
</tr>
<tr>
<td width="958">
<p>3</p>
<p>x x x | x a x | x x x</p>
<p>x a x | a a a | x a x</p>
<p>x x x | x a x | x x x</p>
</td>
<td width="157">
<p>1</p>
<p>a -&gt; 1</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="958">
<p>2</p>
<p>a a | a a</p>
<p>a a | a a</p>
</td>
<td width="157">
<p>0</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h1>2.&nbsp; Guitar</h1>
<p>Bobi is a guitar player and he is going to play a concert. He doesn&rsquo;t like to play all the songs at the same volume, so he decides to <strong>change the volume level</strong> of his guitar before each new song. Before the concert begins, he makes a <strong>list of the number of intervals</strong> he will be changing his volume level by before each song. For each volume change, he will decide whether to <strong>add that number of intervals to the volume or subtract it</strong>.</p>
<p>You are given a list of integers <strong>C</strong>, the i-th element of which is the number of intervals Bobi will change his volume by before the i-th song. You are also given an integer B, the initial volume of Bobi&rsquo;s guitar, and an integer M, the highest possible volume setting of Bobi&rsquo;s guitar. Bobi cannot change the volume of his guitar to a level above M or below 0 (but exactly 0 and exactly M is possible). Your program should print the maximum volume Bobi can use to play the last song. If there is no way to go through the list without exceeding M or going below 0, print -1.</p>
<h2>Input</h2>
<p>The input data should be read from the console.</p>
<p>The elements of the list <strong>C</strong> will be on the first input line separated by a comma and an interval (", ").</p>
<p>On the second line there will be the number <strong>B</strong> and on the third line there will be the number <strong>M</strong>.</p>
<p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h2>Output</h2>
<p>The output data should be printed on the console.</p>
<p>On the only output line you should print <strong>-1</strong> or the maximum volume <strong>Bobi</strong> can use to play the last song.</p>
<h2>Constraints</h2>
<ul>
<li><strong>C</strong> will contain between 1 and 50 elements, inclusive.</li>
<li>In 95% of the tests cases <strong>C</strong> will contain no less than 34 elements.</li>
<li>Each element of <strong>C</strong> will be between 1 and <strong>M</strong>, inclusive.</li>
<li><strong>M</strong> will be between 1 and 1000, inclusive.</li>
<li><strong>B</strong> will be between 0 and <strong>M</strong>, inclusive.</li>
</ul>
<ul>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16</li>
</ul>
<h2>Examples</h2>
<table width="1153">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="170">
<p><strong>Output</strong></p>
</td>
<td width="57">
<p><strong>&nbsp;</strong></p>
</td>
<td width="284">
<p><strong>Input</strong></p>
</td>
<td width="170">
<p><strong>Output</strong></p>
</td>
<td colspan="2" width="246">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="227">
<p>5, 3, 7</p>
<p>5</p>
<p>10</p>
</td>
<td width="170">
<p>10</p>
<p><strong>&nbsp;</strong></p>
</td>
<td width="57">
<p><strong>&nbsp;</strong></p>
</td>
<td width="284">
<p>15, 2, 9, 10</p>
<p>8</p>
<p>20</p>
</td>
<td width="170">
<p>-1</p>
<p>&nbsp;</p>
</td>
<td colspan="2" width="246">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="6" width="1021">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td colspan="6" width="1021">
<p>74, 39, 127, 95, 63, 140, 99, 96, 154, 18, 137, 162, 14, 88</p>
<p>40</p>
<p>243</p>
</td>
<td width="132">
<p>238</p>
<p><strong>&nbsp;</strong></p>
</td>
</tr>
<tr>
<td width="227">&nbsp;</td>
<td width="170">&nbsp;</td>
<td width="57">&nbsp;</td>
<td width="284">&nbsp;</td>
<td width="170">&nbsp;</td>
<td width="113">&nbsp;</td>
<td width="132">&nbsp;</td>
</tr>
</tbody>
</table>
<h1>3.&nbsp; Shortest Path</h1>
<p>You are lost in the dark walking home. Luckily, you have a map for the shortest path available to your house. Well, sort of a map, you have turn directions. The only possible directions for each turn are straight (written with &ldquo;S&rdquo;), left (written with &ldquo;L&rdquo;) and right (&ldquo;written with &ldquo;R&rdquo;). So, the map looks like the following: LSRLRSRLLR, which means &ndash; take left turn, straight, right turn, left turn, right turn, straight, right turn, left turn, left turn, right turn and you are home. Well&hellip; at least looked like that during the last century, because now the map is quite old and some of symbols cannot be read from it (written with &ldquo;*&rdquo;). For example, you may have LR**SR*LL, which means &ndash; take left turn, right turn, all directions are possible, all directions are possible, straight, right turn, all directions are possible, left turn, left turn and you are home. Every &ldquo;*&rdquo; can be either &ldquo;S&rdquo;, &ldquo;L&rdquo; or &ldquo;R&rdquo;. Your task is to find all possible different paths, which can be formed from the partial map.</p>
<h2>Input</h2>
<p>The input data should be read from the console.</p>
<p>On the first and only input line there will be the partial map as sequence of &ldquo;<strong>S</strong>&rdquo;, &ldquo;<strong>L</strong>&rdquo;, &ldquo;<strong>R</strong>&rdquo; and &ldquo;<strong>*</strong>&rdquo;.</p>
<p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h2>Output</h2>
<p>The output data should be printed on the console.</p>
<p>On the first output line, print the number of possible different paths.</p>
<p>On the next output lines, print every possible different path (each on separate line), sorted alphabetically.</p>
<h2>Constraints</h2>
<ul>
<li>The length of the map will be maximum 16 symbols, inclusive.</li>
</ul>
<ul>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16</li>
</ul>
<h2>Examples</h2>
<table>
<tbody>
<tr>
<td width="672">
<p><strong>Input</strong></p>
</td>
<td width="696">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="672">
<p>LSLLRSRL</p>
</td>
<td width="696">
<p>1</p>
<p>LSLLRSRL</p>
</td>
</tr>
<tr>
<td width="672">
<p>R*S*L</p>
</td>
<td width="696">
<p>9</p>
<p>RLSLL</p>
<p>RLSRL</p>
<p>RLSSL</p>
<p>RRSLL</p>
<p>RRSRL</p>
<p>RRSSL</p>
<p>RSSLL</p>
<p>RSSRL</p>
<p>RSSSL</p>
</td>
</tr>
<tr>
<td width="672">
<p>**RLR*</p>
</td>
<td width="696">
<p>27</p>
<p>LLRLRL</p>
<p>LLRLRR</p>
<p>LLRLRS</p>
<p>LRRLRL</p>
<p>LRRLRR</p>
<p>LRRLRS</p>
<p>LSRLRL</p>
<p>LSRLRR</p>
<p>LSRLRS</p>
<p>RLRLRL</p>
<p>RLRLRR</p>
<p>RLRLRS</p>
<p>RRRLRL</p>
<p>RRRLRR</p>
<p>RRRLRS</p>
<p>RSRLRL</p>
<p>RSRLRR</p>
<p>RSRLRS</p>
<p>SLRLRL</p>
<p>SLRLRR</p>
<p>SLRLRS</p>
<p>SRRLRL</p>
<p>SRRLRR</p>
<p>SRRLRS</p>
<p>SSRLRL</p>
<p>SSRLRR</p>
<p>SSRLRS</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>