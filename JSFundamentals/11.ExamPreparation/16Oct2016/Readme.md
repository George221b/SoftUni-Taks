<h1>Problem 1 &ndash; Arithmephile</h1>
<h3>You will be given an input of an arbitrary amount of numbers. If a number S is a digit (0 &gt;= S &lt; 10), calculate the product of multiplication of the next S numbers. Find the biggest product among all the S intervals. Note that the intervals may overlap &ndash; when you&rsquo;ve encountered a number that fits the requirement and have calculated the product, the next valid number S may be within this interval.</h3>
<h3>Input</h3>
<ul>
<li>The input data is passed to the first JavaScript function found in your code as an <strong>array of strings</strong> that need to be parsed as numbers.</li>
</ul>
<h3>Output</h3>
<ul>
<li>A number, the biggest multiplication should be printed on the console.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The input may contain up to <strong>10,000</strong> lines (elements)</li>
<li>The numbers in the input are in range <strong>[-1..10,000] inclusive</strong></li>
<li>The numbers denoting ranges (<strong>S</strong>) are in range <strong>[0..9] inclusive</strong></li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<h3>Examples</h3>
<p>&nbsp;</p>
<table width="1198">
<tbody>
<tr>
<td width="610">
<p><strong>Input</strong></p>
</td>
<td width="588">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="610">
<p>10</p>
<p>20</p>
<p>2</p>
<p>30</p>
<p>44</p>
<p>3</p>
<p>56</p>
<p>20</p>
<p>24</p>
</td>
<td width="588">
<p>26880</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="1198">
<tbody>
<tr>
<td width="610">
<p><strong>Input</strong></p>
</td>
<td width="588">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="610">
<p>100</p>
<p>200</p>
<p>2</p>
<p>3</p>
<p>2</p>
<p>3</p>
<p>2</p>
<p>1</p>
<p>1</p>
</td>
<td width="588">
<p>12</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>1.&nbsp;&nbsp; Rosetta Stone</h2>
<p>A team of archeologists has unearthed a set of very special stone tablets &ndash; it is believed they contain texts from the lost language of the Olmec and the means to translate them. The team has a large number of tablets, some of which contain texts, and others contain a template for decoding the text into English. Deciphering all of them by hand would be tedious, and this is why the lead professor of the team of archeologists has submitted an inquiry with you for a JS&nbsp;program to do it automatically.</p>
<p>You will be given an <strong>encoded message</strong> and a <strong>template matrix</strong> for <strong>decoding</strong> it. The decoding is done by overlaying the template on top of the stone with the message and performing an <strong>arithmetic operation</strong> with the numbers that overlap. Each pair of numbers (one from the message and one from the template matrix) is <strong>added</strong> together and the resulting number is located on the wheel of letters (pictured to the right), by counting from the beginning (<strong>zero</strong>) and going <strong>clockwise</strong>. You may count <strong>more than one full revolution</strong> around the wheel (e.g. 6 is the same as 33 and so on). Repeat this process for all symbols of the message.</p>
<p>If the decoding template matrix is smaller than the message, <strong>shift the template</strong> <strong>horizontally</strong> by as many cells as it is wide, so it covers the next section of the message (see example). Once you reach the last column of the message matrix, if there are more rows left, <strong>shift</strong> the template back to the <strong>first column</strong>, but <strong>offset it vertically</strong> by as many cells as it is high. See the example&rsquo;s explanation for more information.</p>
<h3>Input</h3>
<p>You will receive an <strong>array of strings</strong>. The first element represents a number <strong>n</strong>, which is the length of the <strong>template matrix</strong> for decoding. The next <strong>n</strong> elements represent rows in the decoding template matrix, with columns <strong>separated by space</strong>. The rest of the elements are all rows of the <strong>encoded message matrix</strong>, with columns in each row <strong>separated by space</strong>.</p>
<h3>Output</h3>
<p>Print the decoded message in <strong>uppercase</strong> on a single line on the <strong>console</strong>. The final message is joined from all resulting cells, starting from <strong>top left</strong>, going right, <strong>row by row</strong>. Trailing spaces are <strong>ignored</strong>.</p>
<h3>Examples</h3>
<table width="1058">
<tbody>
<tr>
<td width="378">
<p><strong>Input</strong></p>
</td>
<td width="680">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="378">
<p>[ '2',</p>
<p>&nbsp; '59 36',</p>
<p>&nbsp; '82 52',</p>
<p>&nbsp; '4 18 25 19 8',</p>
<p>&nbsp; '4 2 8 2 18',</p>
<p>&nbsp; '23 14 22 0 22',</p>
<p>&nbsp; '2 17 13 19 20',</p>
<p>&nbsp; '0 9 0 22 22' ]</p>
</td>
<td width="680">
<p>I CAME I SAW I CONQUERED</p>
</td>
</tr>
</tbody>
</table>
<h4>Explanation</h4>
<p>The line highlighted in red in the input is the number of lines of the decoding template matrix. The lines highlighted in blue are the decoding template itself. The remaining lines are the encoded message matrix. When we overlay the template over the message, 59 and 36 from the first line are on top of 4 and 18, 82 and 52 are on top of 4 and 2.</p>
<table>
<tbody>
<tr>
<td colspan="2" width="1020">
<p>We add each pair to get 63 and 54 on the first line and 86 and 54 on the second. Looking up these numbers on the wheel of letters yields the following:</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For 63 we count two full revolutions and then we count 9 more, which corresponds to the letter &lsquo;I&rsquo;</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For 54 we count exactly two full revolutions, ending at 0, which is empty space</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For 86 we count 3 full revolutions and 5 more, ending at &lsquo;E&rsquo;</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For 54 we get empty space again</p>
<p>&nbsp;</p>
</td>
<td width="370">&nbsp;</td>
<td width="1">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="2" width="1020">
<p>We&rsquo;ve ran out of slots on the template, so we shift it 2 indexes to the right (the width of the template is 2), to decode the next segment of the message. This time we overlay it on top of 25, 19, 8 and 2 and after adding the numbers, we get 84, 55, 90 and 54. They correspond to &lsquo;C&rsquo;, &lsquo;A&rsquo;, &lsquo;I&rsquo; and empty space, respectively.</p>
</td>
<td width="370">&nbsp;</td>
<td width="1">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="567">
<p>We keep repeating this for the entire message. Once we reach the end of the row, we shift the template down by its height (2&nbsp;cells) and back to the beginning of the message. Any slots of the template that overhang at the end of the row are ignored.</p>
</td>
<td colspan="3" width="824">
<p>&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="4" width="1391">
<p>The process is repeated for all remaining cells of the message. Note any parts of the template matrix that overhang bellow are ignored.</p>
</td>
</tr>
<tr>
<td colspan="4" width="1391">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="4" width="1391">&nbsp;</td>
</tr>
<tr>
<td width="567">&nbsp;</td>
<td width="375">&nbsp;</td>
<td width="370">&nbsp;</td>
<td width="1">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1058">
<tbody>
<tr>
<td width="378">
<p><strong>Input</strong></p>
</td>
<td width="680">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="378">
<p>[ '2',</p>
<p>&nbsp; '31 32',</p>
<p>&nbsp; '74 37',</p>
<p>&nbsp; '19 0 23 25',</p>
<p>&nbsp; '22 3 12 17',</p>
<p>&nbsp; '5 9 23 11',</p>
<p>&nbsp; '12 18 10 22' ]</p>
</td>
<td width="680">
<p>WE COME IN PEACE</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>

<h2>1.&nbsp;&nbsp; Rosetta Stone</h2>
<p>A team of archeologists has unearthed a set of very special stone tablets &ndash; it is believed they contain texts from the lost language of the Olmec and the means to translate them. The team has a large number of tablets, some of which contain texts, and others contain a template for decoding the text into English. Deciphering all of them by hand would be tedious, and this is why the lead professor of the team of archeologists has submitted an inquiry with you for a JS&nbsp;program to do it automatically.</p>
<p>You will be given an <strong>encoded message</strong> and a <strong>template matrix</strong> for <strong>decoding</strong> it. The decoding is done by overlaying the template on top of the stone with the message and performing an <strong>arithmetic operation</strong> with the numbers that overlap. Each pair of numbers (one from the message and one from the template matrix) is <strong>added</strong> together and the resulting number is located on the wheel of letters (pictured to the right), by counting from the beginning (<strong>zero</strong>) and going <strong>clockwise</strong>. You may count <strong>more than one full revolution</strong> around the wheel (e.g. 6 is the same as 33 and so on). Repeat this process for all symbols of the message.</p>
<p>If the decoding template matrix is smaller than the message, <strong>shift the template</strong> <strong>horizontally</strong> by as many cells as it is wide, so it covers the next section of the message (see example). Once you reach the last column of the message matrix, if there are more rows left, <strong>shift</strong> the template back to the <strong>first column</strong>, but <strong>offset it vertically</strong> by as many cells as it is high. See the example&rsquo;s explanation for more information.</p>
<h3>Input</h3>
<p>You will receive an <strong>array of strings</strong>. The first element represents a number <strong>n</strong>, which is the length of the <strong>template matrix</strong> for decoding. The next <strong>n</strong> elements represent rows in the decoding template matrix, with columns <strong>separated by space</strong>. The rest of the elements are all rows of the <strong>encoded message matrix</strong>, with columns in each row <strong>separated by space</strong>.</p>
<h3>Output</h3>
<p>Print the decoded message in <strong>uppercase</strong> on a single line on the <strong>console</strong>. The final message is joined from all resulting cells, starting from <strong>top left</strong>, going right, <strong>row by row</strong>. Trailing spaces are <strong>ignored</strong>.</p>
<h3>Examples</h3>
<table width="1058">
<tbody>
<tr>
<td width="378">
<p><strong>Input</strong></p>
</td>
<td width="680">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="378">
<p>[ '2',</p>
<p>&nbsp; '59 36',</p>
<p>&nbsp; '82 52',</p>
<p>&nbsp; '4 18 25 19 8',</p>
<p>&nbsp; '4 2 8 2 18',</p>
<p>&nbsp; '23 14 22 0 22',</p>
<p>&nbsp; '2 17 13 19 20',</p>
<p>&nbsp; '0 9 0 22 22' ]</p>
</td>
<td width="680">
<p>I CAME I SAW I CONQUERED</p>
</td>
</tr>
</tbody>
</table>
<h4>Explanation</h4>
<p>The line highlighted in red in the input is the number of lines of the decoding template matrix. The lines highlighted in blue are the decoding template itself. The remaining lines are the encoded message matrix. When we overlay the template over the message, 59 and 36 from the first line are on top of 4 and 18, 82 and 52 are on top of 4 and 2.</p>
<table>
<tbody>
<tr>
<td colspan="2" width="1020">
<p>We add each pair to get 63 and 54 on the first line and 86 and 54 on the second. Looking up these numbers on the wheel of letters yields the following:</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For 63 we count two full revolutions and then we count 9 more, which corresponds to the letter &lsquo;I&rsquo;</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For 54 we count exactly two full revolutions, ending at 0, which is empty space</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For 86 we count 3 full revolutions and 5 more, ending at &lsquo;E&rsquo;</p>
<p>&middot;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For 54 we get empty space again</p>
<p>&nbsp;</p>
</td>
<td width="370">&nbsp;</td>
<td width="1">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="2" width="1020">
<p>We&rsquo;ve ran out of slots on the template, so we shift it 2 indexes to the right (the width of the template is 2), to decode the next segment of the message. This time we overlay it on top of 25, 19, 8 and 2 and after adding the numbers, we get 84, 55, 90 and 54. They correspond to &lsquo;C&rsquo;, &lsquo;A&rsquo;, &lsquo;I&rsquo; and empty space, respectively.</p>
</td>
<td width="370">&nbsp;</td>
<td width="1">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="567">
<p>We keep repeating this for the entire message. Once we reach the end of the row, we shift the template down by its height (2&nbsp;cells) and back to the beginning of the message. Any slots of the template that overhang at the end of the row are ignored.</p>
</td>
<td colspan="3" width="824">
<p>&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="4" width="1391">
<p>The process is repeated for all remaining cells of the message. Note any parts of the template matrix that overhang bellow are ignored.</p>
</td>
</tr>
<tr>
<td colspan="4" width="1391">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="4" width="1391">&nbsp;</td>
</tr>
<tr>
<td width="567">&nbsp;</td>
<td width="375">&nbsp;</td>
<td width="370">&nbsp;</td>
<td width="1">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1058">
<tbody>
<tr>
<td width="378">
<p><strong>Input</strong></p>
</td>
<td width="680">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="378">
<p>[ '2',</p>
<p>&nbsp; '31 32',</p>
<p>&nbsp; '74 37',</p>
<p>&nbsp; '19 0 23 25',</p>
<p>&nbsp; '22 3 12 17',</p>
<p>&nbsp; '5 9 23 11',</p>
<p>&nbsp; '12 18 10 22' ]</p>
</td>
<td width="680">
<p>WE COME IN PEACE</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>


<h1>Problem 3 - Spy Master</h1>
<p>You are the spy master of a guild of spies, since you&rsquo;re all carefully watched, your spies communicate with you by leaving <strong>encoded messages</strong>. You will receive a <strong>special key</strong> and <strong>lines of text</strong> which you must comb in order to find the <strong>encoded messages</strong>.</p>
<p>The special key will consist only of <strong>one or more</strong> <strong>English letters</strong>.</p>
<ul>
<li>The special key must be preceded by either a <strong>space</strong> or the <strong>start of the string</strong> in order to be considered valid in the string.</li>
<li>The special key may appear in <strong>any casing</strong> (its letters could be a random mix of lower and uppercase) in the <strong>lines of text</strong>.</li>
</ul>
<p>Valid encoded messages must meet these requirements:</p>
<ul>
<li>An <strong>encoded message</strong> must immediately follow the <strong>special key</strong>, being separated from it only by <strong>one or more spaces</strong>.</li>
<li>An encoded message must be <strong>at least</strong> <strong>8 symbols long</strong> and consist only of the symbols<strong> !</strong>,<strong> %</strong>, <strong>$</strong>, <strong>#</strong> or <strong>Capital English letters</strong>.</li>
<li>The encoded message must be followed by a <strong>space</strong>, a<strong> dot (.)</strong>, a<strong> comma (,)</strong> or the <strong>end of the string</strong>.</li>
</ul>
<p>After finding the correct <strong>encoded messages</strong>, you must <strong>decode</strong> and <strong>replace them in the original text</strong>. The decoding should be as follows:</p>
<ul>
<li>The symbol <strong>!</strong> becomes the number <strong>1</strong></li>
<li>The symbol <strong>%</strong> becomes the number <strong>2</strong></li>
<li>The symbol <strong>#</strong> becomes the number <strong>3</strong></li>
<li>The symbol <strong>$</strong> should become the number <strong>4</strong></li>
<li><strong>Capital English letters </strong>should become their<strong> lower case counterparts</strong></li>
</ul>
<h3>Constraints</h3>
<ul>
<li>A pair of a <strong>special key</strong> and <strong>encoded message</strong> will never be split between multiple lines.</li>
<li>The preceding space before a <strong>special key</strong> will never overlap with a trailing space after an <strong>encoded message</strong>.</li>
<li>There will never be an <strong>encoded message</strong> equal to the <strong>special key</strong>.</li>
</ul>
<h3>Input</h3>
<p>The <strong>input</strong> comes as an array of strings - the first element is the <strong>special key</strong>, each element after it is a <strong>line of text</strong>.</p>
<h3>Output</h3>
<p>The <strong>output</strong> should be printed on the console - consisting of the entire text with the <strong>correct</strong> <strong>encoded messages</strong> replaced with their <strong>decoded</strong> versions, each <strong>line of text</strong> on a new line.</p>
<h3>Examples</h3>
<table width="1412">
<tbody>
<tr>
<td width="1412">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="1412">
<p>specialKey</p>
<p>In this text the specialKey HELLOWORLD! is correct, but</p>
<p>the following specialKey $HelloWorl#d and spEcIaLKEy HOLLOWORLD1 are not, while</p>
<p>SpeCIaLkeY&nbsp;&nbsp; SOM%%ETH$IN and SPECIALKEY ##$$##$$ are!</p>
</td>
</tr>
<tr>
<td width="1412">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1412">
<p>In this text the specialKey helloworld1 is correct, but</p>
<p>the following specialKey $HelloWorl#d and spEcIaLKEy HOLLOWORLD1 are not, while</p>
<p>SpeCIaLkeY&nbsp;&nbsp; som22eth4in and SPECIALKEY 33443344 are!</p>
</td>
</tr>
<tr>
<td width="1412">
<p>Input</p>
</td>
</tr>
<tr>
<td width="1412">
<p>enCode</p>
<p>Some messages are just not encoded what can you do?</p>
<p>RE - ENCODE THEMNOW! - he said.</p>
<p>Damn encode, ITSALLHETHINKSABOUT, eNcoDe BULL$#!%.</p>
</td>
</tr>
<tr>
<td width="1412">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1412">
<p>Some messages are just not encoded what can you do?</p>
<p>RE - ENCODE themnow1 - he said.</p>
<p>Damn encode, ITSALLHETHINKSABOUT, eNcoDe bull4312.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h1>Problem 4 &ndash; Radical Marketing</h1>
<p>You have been given control over a large partition of the financial markets at Wall Street. Your task is to track and make logs of the important people there. The business there is quite complex, so there are a few things you must follow.</p>
<p>You need to implement functionality that allows you to <strong>register people</strong> in your log database. These people must also be <strong>uniquely named</strong>. There is a<strong> specified command input</strong> that triggers this functionality.</p>
<p><strong>People</strong> also like to <strong>subscribe</strong> to <strong>other people</strong>, so that they can follow their actions and analyze them, which is essential to marketing.</p>
<p>One person <strong>can subscribe</strong> to <strong>as many people</strong> <strong>as he wants</strong>. He <strong>CANNOT</strong> however subscribe to <strong>himself </strong>or subscribe to a person he is <strong>already a subscriber</strong> of.</p>
<h3>Input</h3>
<ul>
<li>The <strong>input</strong> comes as array of strings. Each element will represent a <strong>valid</strong> The commands are in a specific format:</li>
</ul>
<p>&nbsp;</p>
<ul>
<li>&ldquo;{person}&rdquo; &ndash; <strong>registers</strong> a person into the log database. In case the <strong>given</strong> <strong>person already exists</strong>, <strong>IGNORE </strong>that command.</li>
</ul>
<p>&nbsp;</p>
<ul>
<li>&ldquo;{firstPerson}-{secondPerson}&rdquo; &ndash; subscribes the first person to the second. If <strong>one</strong> or <strong>both</strong> of the <strong>given </strong><strong>persons</strong> <strong>do NOT exist</strong> in the log, you should <strong>IGNORE</strong> that command</li>
</ul>
<p>&nbsp;</p>
<p>When you&rsquo;ve processed the whole input, you must find <strong>the person with</strong> <strong>the most subscribers</strong>, because he is the most important person on the markets. If, however, two persons have the same amount of subscribers, you must find <strong>that one which is a subscriber of more people</strong>, because that would mean he is more experienced on the markets and is following and analyzing a lot of people. If even then there are equal people, pick the <strong>first entered</strong>.</p>
<h3>Output</h3>
<ul>
<li>The <strong>output</strong> person should be printed along with <strong>his subscribers</strong>, in the following format:</li>
</ul>
<p>&nbsp;</p>
<p>&ldquo;{person}</p>
<ol>
<li>{subscriber1}</li>
<li>{subscriber2}</li>
</ol>
<p>&nbsp;...</p>
<ul>
<li>The s<strong>ubscribers</strong> should be printed in <strong>order of subscription</strong>.</li>
<li>If there are no subscribers, just print the <strong>person&rsquo;s name</strong>.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>There will be no invalid input.</li>
<li>The subscribers will be strings, which <strong>will </strong><strong>always be Capital English alphabet letters</strong>.</li>
<li>Allowed time/memory: 200ms/16MB.</li>
</ul>
<p>&nbsp;</p>
<table width="1198">
<tbody>
<tr>
<td width="610">
<p><strong>Input</strong></p>
</td>
<td width="588">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="610">
<p>A</p>
<p>B</p>
<p>C</p>
<p>D</p>
<p>A-B</p>
<p>B-A</p>
<p>C-A</p>
<p>D-A</p>
</td>
<td width="588">
<p>A</p>
<p>1. B</p>
<p>2. C</p>
<p>3. D</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="1198">
<tbody>
<tr>
<td width="610">
<p><strong>Input</strong></p>
</td>
<td width="588">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="610">
<p>J</p>
<p>G</p>
<p>P</p>
<p>R</p>
<p>C</p>
<p>J-G</p>
<p>G-J</p>
<p>P-R</p>
<p>R-P</p>
<p>C-J</p>
</td>
<td width="588">
<p>J</p>
<p>1. G</p>
<p>2. C</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>