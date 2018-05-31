<h1>Problem 1 &ndash; The Pyramid of King Djoser</h1>
<p><em>Glory to Imhotep, Creator of all things material, Chancellor of the King of Egypt, Doctor, First in line after the King of Upper Egypt, Administrator of the Great Palace, Hereditary nobleman, High Priest of Heliopolis, Builder, Chief Carpenter, Chief Sculptor, and Maker of Vases in Chief. It is by King Djoser&rsquo;s decree that on this day we shall commence the construction of a Great Pyramid for our King. Imhotep, son of Ptah, demands that you honour your King by calculating the building materials needed to finish His home for the Afterlife.</em></p>
<p>Write a JS program that calculates how much resources will be required for the construction of a pyramid. It is made out of <strong>stone</strong>, <strong>marble</strong>, <strong>lapis lazuli</strong> and <strong>gold</strong>. Your program will receive an integer that will be the <strong>base</strong> width and length of the pyramid and an <strong>increment</strong>, that is the height of each step. The bulk is made out of stone, while the <strong>outer layer</strong> is made out of marble. <strong>Every fifth step&rsquo;s</strong> outer layer is made out of lapis lazuli <strong>instead</strong> of marble. The <strong>final step</strong> is made out of gold.</p>
<p>The pyramid is built with <strong>1x1 blocks</strong> with <strong>height</strong> equal to the given <strong>increment</strong>. The first step of the pyramid has <strong>width</strong> and <strong>length</strong> equal to the given <strong>base</strong> and every next step is <strong>reduced by 2 blocks</strong> (1 from each side). The height of every step equals the given <strong>increment</strong>. See the drawing for an example. White steps are covered in marble, blue steps are covered in lapis lazuli (<strong>every fifth layer from the bottom</strong>), and yellow steps are made <strong>entirely</strong> out of gold (<strong>top-most step</strong>).</p>
<p>Since the <strong>outer layer</strong> of each step is made of a decorative material, to calculate the required stone for one step, reduce the width and length by 2 blocks (one from each side), find it&rsquo;s area and multiply it by the increment. The rest of the step is made out of lapis lazuli for every fifth step from the bottom and marble for all other steps. To find the amount needed, you may, for example, find its perimeter and reduce it by 4 (to compensate for the overlapping corners) and multiply the result by the increment. See the drawing for details (grey is stone, white is decoration).</p>
<table>
<tbody>
<tr>
<td width="463">&nbsp;</td>
<td width="463">&nbsp;</td>
<td width="463">&nbsp;</td>
</tr>
<tr>
<td width="463">
<p>5x5 step</p>
<p>Stone required &ndash; 9 x increment</p>
<p>Marble required &ndash; 16 x increment</p>
</td>
<td width="463">
<p>7x7 step</p>
<p>Stone required &ndash; 25 x increment</p>
<p>Marble required &ndash; 24 x increment</p>
</td>
<td width="463">
<p>8x8 step</p>
<p>Stone required &ndash; 36 x increment</p>
<p>Marble required &ndash; 28 x increment</p>
</td>
</tr>
</tbody>
</table>
<p>Note the top-most layer is made entirely out of gold, with height equal to the given increment. See the examples for complete calculations.</p>
<h3>Input</h3>
<p>You will receive two <strong>number</strong> parameters <strong>base</strong> and <strong>increment</strong>.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> on separate lines the <strong>total</strong> required <strong>amounts</strong> of each material <strong>rounded up</strong> and the <strong>final height</strong> of the pyramid <strong>rounded down</strong>, as shown in the examples.</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>base </strong>will always be an integer greater than zero</li>
<li>The <strong>increment</strong> will always be a number greater than zero</li>
<li>MAX_SAFE_INTEGER will <strong>never be exceeded</strong> for any of the calculations</li>
</ul>
<h3>Examples</h3>
<table width="1391">
<tbody>
<tr>
<td width="110">
<p><strong>Input</strong></p>
</td>
<td width="435">
<p><strong>Output</strong></p>
</td>
<td colspan="6" width="847">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td rowspan="8" width="110">
<p>11,</p>
<p>1</p>
</td>
<td rowspan="8" width="435">
<p>Stone required: 165</p>
<p>Marble required: 112</p>
<p>Lapis Lazuli required: 8</p>
<p>Gold required: 1</p>
<p>Final pyramid height: 6</p>
</td>
<td width="95">
<p>Step</p>
</td>
<td width="150">
<p>Size</p>
</td>
<td width="150">
<p>Stone</p>
</td>
<td width="150">
<p>Marble</p>
</td>
<td width="150">
<p>Lapis</p>
</td>
<td width="150">
<p>Gold</p>
</td>
</tr>
<tr>
<td width="95">
<p>1<sup>st</sup></p>
</td>
<td width="150">
<p>11x11</p>
</td>
<td width="150">
<p>81</p>
</td>
<td width="150">
<p>40</p>
</td>
<td width="150">
<p>-</p>
</td>
<td width="150">
<p>-</p>
</td>
</tr>
<tr>
<td width="95">
<p>2<sup>nd</sup></p>
</td>
<td width="150">
<p>9x9</p>
</td>
<td width="150">
<p>49</p>
</td>
<td width="150">
<p>32</p>
</td>
<td width="150">
<p>-</p>
</td>
<td width="150">
<p>-</p>
</td>
</tr>
<tr>
<td width="95">
<p>3<sup>rd</sup></p>
</td>
<td width="150">
<p>7x7</p>
</td>
<td width="150">
<p>25</p>
</td>
<td width="150">
<p>24</p>
</td>
<td width="150">
<p>-</p>
</td>
<td width="150">
<p>-</p>
</td>
</tr>
<tr>
<td width="95">
<p>4<sup>th</sup></p>
</td>
<td width="150">
<p>5x5</p>
</td>
<td width="150">
<p>9</p>
</td>
<td width="150">
<p>16</p>
</td>
<td width="150">
<p>-</p>
</td>
<td width="150">
<p>-</p>
</td>
</tr>
<tr>
<td width="95">
<p>5<sup>th</sup></p>
</td>
<td width="150">
<p>3x3</p>
</td>
<td width="150">
<p>1</p>
</td>
<td width="150">
<p>-</p>
</td>
<td width="150">
<p>8</p>
</td>
<td width="150">
<p>-</p>
</td>
</tr>
<tr>
<td width="95">
<p>6<sup>th</sup></p>
</td>
<td width="150">
<p>1x1</p>
</td>
<td width="150">
<p>-</p>
</td>
<td width="150">
<p>-</p>
</td>
<td width="150">
<p>-</p>
</td>
<td width="150">
<p>1</p>
</td>
</tr>
<tr>
<td width="95">
<p>total</p>
</td>
<td width="150">
<p>Height=6</p>
</td>
<td width="150">
<p>165</p>
</td>
<td width="150">
<p>112</p>
</td>
<td width="150">
<p>8</p>
</td>
<td width="150">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="110">
<p><strong>Input</strong></p>
</td>
<td width="435">
<p><strong>Output</strong></p>
</td>
<td width="847">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="110">
<p>11,</p>
<p>0.75</p>
</td>
<td width="435">
<p>Stone required: 124</p>
<p>Marble required: 84</p>
<p>Lapis Lazuli required: 6</p>
<p>Gold required: 1</p>
<p>Final pyramid height: 4</p>
</td>
<td width="847">
<p>Total <strong>stone</strong> is 81*0.75+49*0.75+25*0.75+9*0.75+1*0.75 = 123.75, we round up to 124.</p>
<p>Total <strong>marble</strong> is 40*0.75+32*0.75+24*0.75+16*0.75=84.</p>
<p>Total <strong>lapis lazuli</strong> is 8*0.75=6.</p>
<p>Total <strong>gold</strong> is 1*0.75=0.75, we round up to 1.</p>
<p>Total <strong>height</strong> is 4.5 (6 <strong>steps</strong> times 0.75), we round down to 4.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="491">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="106">
<p><strong>&nbsp;</strong></p>
</td>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="491">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>12,</p>
<p>1</p>
</td>
<td width="491">
<p>Stone required: 220</p>
<p>Marble required: 128</p>
<p>Lapis Lazuli required: 12</p>
<p>Gold required: 4</p>
<p>Final pyramid height: 6</p>
</td>
<td width="151">
<p>23,</p>
<p>0.5</p>
</td>
<td width="491">
<p>Stone required: 886</p>
<p>Marble required: 228</p>
<p>Lapis Lazuli required: 36</p>
<p>Gold required: 1</p>
<p>Final pyramid height: 6</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h1>Problem 2 &ndash; Jan&rsquo;s Notation</h1>
<p><em>Jan is a brilliant mathematician. With brilliance though comes bizzarity, and Jan has invented his own mathematic notation &ndash; he writes the operator after his operands, so he can save space by not writing any parenthesis. He asked from you to create an automated calculator that works with his notation, so he can prove to the world it&rsquo;s the better way to do math!</em></p>
<p>Write a JS program that parses a series of instructions written in <strong>postfix notation</strong> and executes them (postfix means the operator is written <strong>after</strong> the operands). You will receive a <strong>series of instructions</strong> &ndash; if the instruction is a <strong>number</strong>, <strong>save it</strong>; otherwise, the instruction is an <strong>arithmetic operator</strong> (+-*/) and you must apply it to the most two <strong>most recently saved</strong> numbers. <strong>Discard</strong> these two numbers and in their place, <strong>save the result</strong> of the operation &ndash; this number is now eligible to be an <strong>operand</strong> in a subsequent operation. Keep going until all input instructions have been exhausted, or you encounter an error.</p>
<p>In the end, if you&rsquo;re left with a <strong>single saved number</strong>, this is the <strong>result</strong> of the calculation and you must <strong>print</strong> it. If there are more numbers saved, then the user supplied <strong>too many instructions</strong> and you must print "Error: too many operands!". If at any point during the calculation you <strong>don&rsquo;t have</strong> two number saved, the user supplied <strong>too few instructions</strong> and you must print "Error: not enough operands!". <strong><em>See the examples for more details.</em></strong></p>
<h3>Input</h3>
<p>You will receive an array with numbers <strong>and</strong> strings &ndash; the numbers will be <strong>operands</strong> and must be saved; the strings will be <strong>arithmetic operators</strong> that must be applied to the operands.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> on a single line the <strong>final result</strong> of the calculation or an <strong>error message</strong>, as instructed above.</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>numbers</strong> (operands) will be integers</li>
<li>The <strong>strings</strong> (operators) will always be one of +-*/</li>
<li>The result of each operation will be in range [-2<sup>53</sup>&hellip;2<sup>53</sup>-1] (MAX_SAFE_INTEGER will <strong>never</strong> be exceeded)</li>
</ul>
<h3>Examples</h3>
<table width="1391">
<tbody>
<tr>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="151">
<p><strong>Output</strong></p>
</td>
<td width="1089">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>[3,</p>
<p>&nbsp;4,</p>
<p>&nbsp;'+']</p>
</td>
<td width="151">
<p>7</p>
</td>
<td width="1089">
<p>The first instruction is a <strong>number</strong>, therefor we <strong>save</strong> it. The next one is also a <strong>number</strong>, we <strong>save</strong> it too.</p>
<p>The third instruction is a <strong>string</strong>, so it must be an <strong>operator</strong> &ndash; we <strong>remove the last two</strong> numbers we saved, and perform the operation: 3+4=7. The result of this operation is then <strong>saved</strong> where the two operands <strong>used to be</strong>.</p>
<p>We&rsquo;ve ran out of instructions, so we check the saved values &ndash; we only have <strong>one</strong>, so this must be <strong>final result</strong>. We <strong>print</strong> it on the console.</p>
</td>
</tr>
<tr>
<td width="151">
<p>[5,</p>
<p>&nbsp;3,</p>
<p>&nbsp;4,</p>
<p>&nbsp;'*',</p>
<p>&nbsp;'-']</p>
</td>
<td width="151">
<p>-7</p>
</td>
<td width="1089">
<p>We save in order <strong>5</strong>, <strong>3</strong> and <strong>4</strong>. The result of the operation 3*4 is <strong>12</strong>, which we <strong>save in place</strong> of <strong>3</strong> and <strong>4</strong>.</p>
<p>Currently we have <strong>5</strong> and <strong>12</strong> saved. The result of the operation 5-12 is <strong>-7</strong>, which we <strong>save in place</strong> of <strong>5</strong> and <strong>12</strong>.</p>
<p>We have no more instructions and <strong>only one</strong> value saved, which we <strong>print</strong>.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="491">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="106">
<p><strong>&nbsp;</strong></p>
</td>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="491">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>[7,</p>
<p>&nbsp;33,</p>
<p>&nbsp;8,</p>
<p>&nbsp;'-']</p>
</td>
<td width="491">
<p>Error: too many operands!</p>
</td>
<td width="151">
<p>[15,</p>
<p>&nbsp;'/']</p>
</td>
<td width="491">
<p>Error: not enough operands!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="1391">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="151">
<p><strong>Output</strong></p>
</td>
<td width="302">
<p><strong>Explanation</strong></p>
</td>
<td rowspan="2" width="106">
<p><strong>&nbsp;</strong></p>
</td>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="151">
<p><strong>Output</strong></p>
</td>
<td width="302">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>[31,</p>
<p>&nbsp;2,</p>
<p>&nbsp;'+',</p>
<p>&nbsp;11,</p>
<p>&nbsp;'/']</p>
</td>
<td width="151">
<p>3</p>
</td>
<td width="302">
<p>(31+2)/11</p>
</td>
<td width="189">
<p>[-1,</p>
<p>&nbsp;1,</p>
<p>&nbsp;'+',</p>
<p>&nbsp;101,</p>
<p>&nbsp;'*',</p>
<p>&nbsp;18,</p>
<p>&nbsp;'+',</p>
<p>&nbsp;3,</p>
<p>&nbsp;'/']</p>
</td>
<td width="151">
<p>6</p>
</td>
<td width="302">
<p>(-1+1)*101+18/3</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h1>Problem 3 &ndash; XML Messenger</h1>
<p><em>XML may not see much use these days, but there is legacy software out there that needs maintenance. You are tasked by your boss to add an HTML parser to an old messaging app. The catch &ndash; it has to support all of its versions!</em></p>
<p>Write a JavaScript program that parses messages from XML format to HTML for display on a web page. A message has a body (the text) and attributes, which contain metadata &ndash; who sent the message, and who it is targeted at. This is the general format:</p>
<p>&lt;message to="Alice" from="Bob"&gt;This is a test&lt;/message&gt;</p>
<p>A valid message will <strong>always be enclosed</strong> in an opening and closing &lt;message&gt; tags and will have <strong>no extra characters</strong> before the opening and after the closing tag. Inside the opening tag, there will be only valid attributes. If the message does not match this format or not all characters belong to an attribute, print "Invalid message format".</p>
<p>The opening tag contains the <strong>attributes</strong>. An attribute is in the form key="value", where the <strong>key</strong> will only contain <strong>lowercase Latin letters</strong> and the <strong>value</strong> will contain <strong>Latin alphanumeric characters, spaces and dots</strong>. Both key and value must be <strong>at least one character long</strong>. Characters which do not belong to a valid attribute must not be accepted &ndash; such messages are <strong>invalid</strong>. If the message format is valid, but it doesn&rsquo;t have both valid to and from attributes, print "Missing attributes".</p>
<p>Messages come from different versions of the software, so they <strong>may have additional attributes</strong>, but we only care about the sender and recipient. The to and from attributes <strong>may appear in</strong> <strong>different order</strong> along with other attributes, which we ignore &ndash; the message is still <strong>valid</strong>.</p>
<p>The body of the message <strong>may contain any character</strong>, including line breaks (\n control symbol) &ndash; there is no need to validate it. Every time you encounter a line break, you must print the following text in a new paragraph. <strong>See the examples for details</strong>.</p>
<p>The following message are <strong>all valid</strong>:</p>
<p>&lt;message to="Bob" from="Alice" timestamp="1497254092"&gt;Hey man, what's up?&lt;/message&gt;</p>
<p>&lt;message from="Ivan Ivanov" to="Grace"&gt;Not much, just chillin. How about you?&lt;/message&gt;</p>
<p>&lt;message to="MasterBlaster" from="TheAnimal" timestamp="1497254114"&gt;Same old, same old\nLet's go out for a beer&lt;/message&gt;</p>
<p>&lt;message version="2.0" to="Alice" from="Charlie"&gt;TGIF!&lt;/message&gt;</p>
<p>The sender of the message is highlighted in green, while the recipient is in blue. Note the order may be mixed and the additional attributes are just ignored (but are still in valid key-value format).</p>
<p>The following messages are <strong>all invalid</strong> and an <strong>error message</strong> must be printed, as instructed above:</p>
<table width="1391">
<tbody>
<tr>
<td width="937">
<p><strong>Message</strong></p>
</td>
<td width="454">
<p><strong>Reason</strong></p>
</td>
</tr>
<tr>
<td width="937">
<p>&lt;message from="Alice" timestamp="1497254112"&gt;This is a test&lt;/message&gt;</p>
</td>
<td width="454">
<p>missing to attribute</p>
</td>
</tr>
<tr>
<td width="937">
<p>&lt;message to="Matilda" from="Charlie"&gt;&lt;media type="image" src="slyfox.jpg"/&gt;&lt;/message&gt;&lt;meta version="2.0"/&gt;</p>
</td>
<td width="454">
<p>extra characters after closing tag</p>
</td>
</tr>
<tr>
<td width="937">
<p>&lt;message from="MasterBlaster" to="TheAnimal" color="#FF340B"&gt;FWD: Funny stuff&lt;/message&gt;</p>
</td>
<td width="454">
<p>invalid characters in attribute (don&rsquo;t form a valid attribute)</p>
</td>
</tr>
<tr>
<td width="937">
<p>&lt;message from="Hillary" to="Edward" secret:true&gt;VGhpcyBpcyBhIHRlc3Q&lt;/message&gt;</p>
</td>
<td width="454">
<p>invalid characters in opening tag (don&rsquo;t form a valid attribute)</p>
</td>
</tr>
</tbody>
</table>
<p>After you parse the message and extract the sender, recipient and message body, print the HTML-formatted result:</p>
<p>&lt;article&gt;</p>
<p>&nbsp; &lt;div&gt;From: &lt;span class="sender"&gt;Alice&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;To: &lt;span class="recipient"&gt;Bob&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Same old, same old&lt;/p&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/article&gt;</p>
<p>Note that if there is a <strong>line break</strong> in the message body, you have to add an additional <strong>paragraph</strong>. Nested elements are <strong>indented</strong> by two spaces for each level. <strong>See the examples for more details</strong>.</p>
<h3>Input</h3>
<p>You will receive a <strong>single string</strong> as input &ndash; a message that needs to be <strong>validated</strong>.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> the HTML-formatted <strong>result</strong> or an <strong>error message</strong>, depending on the validation.</p>
<h3>Constraints</h3>
<ul>
<li>The message body will not contain XML brackets (&lt;&gt;), there is no need to validate it</li>
<li>There may be any number of spaces before and after an attribute</li>
<li>An attribute will <strong>not</strong> contain spaces before or after the equal sign</li>
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
<p>&lt;message to="Bob" from="Alice" timestamp="1497254092"&gt;Hey man, what's up?&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;article&gt;</p>
<p>&nbsp; &lt;div&gt;From: &lt;span class="sender"&gt;Alice&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;To: &lt;span class="recipient"&gt;Bob&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Hey man, what's up?&lt;/p&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/article&gt;</p>
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
<p>&lt;message from="John Doe" to="Alice"&gt;Not much, just chillin. How about you?&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;article&gt;</p>
<p>&nbsp; &lt;div&gt;From: &lt;span class="sender"&gt;John Doe&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;To: &lt;span class="recipient"&gt;Alice&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Not much, just chillin. How about you?&lt;/p&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/article&gt;</p>
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
<p>&lt;message from="Alice" timestamp="1497254112"&gt;Same old, same old&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Missing attributes</p>
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
<p>&lt;message to="Bob" from="Alice" timestamp="1497254114"&gt;Same old, same old</p>
<p>Let's go out for a beer&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>&lt;article&gt;</p>
<p>&nbsp; &lt;div&gt;From: &lt;span class="sender"&gt;Alice&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;To: &lt;span class="recipient"&gt;Bob&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Same old, same old&lt;/p&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Let's go out for a beer&lt;/p&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/article&gt;</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Note</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Note the line break in the input message &ndash; the body has an extra paragraph! To test locally, place a \n control symbol in the string.</p>
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
<p>&lt;message to="Alice" from="Charlie"&gt;&lt;img src="fox.jpg"/&gt;&lt;/message&gt;&lt;meta version="2"/&gt;</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Invalid message format</p>
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
<p>&lt;message from="Hillary" to="Edward" secret:true&gt;VGhpcyBpcyBhIHRlc3Q&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Invalid message format</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h1>Problem 4 &ndash; Galactic Elections</h1>
<p><em>Once in a galactic microcycle, a galactic president is chosen. There are many star systems with many planets and even more voters on each planet, so to simplify the process, each system performs and internal election and then sends all of their votes for a single candidate. Even then, the process is lengthy so a software solution is requested of you.</em></p>
<p>Write a JS program that summarizes the results from an election. You will receive an <strong>array of ballots</strong> and each ballot will be an <strong>object</strong> with format:</p>
<p>{</p>
<p>&nbsp; system: String,</p>
<p>&nbsp; candidate: String,</p>
<p>&nbsp; votes: Number</p>
<p>}</p>
<p>The system property is the name of the star system from which the ballot comes, candidate is the name of the candidate for which the votes are cast and votes is the number of votes for said candidate. Go through all of the ballots and store the total votes for each star system per candidate.</p>
<p>After you&rsquo;ve stored the votes, it&rsquo;s time to see who&rsquo;s the winner. For <strong>each star system</strong>, the candidate with the <strong>most votes</strong> in that system, takes it for himself (<strong>wins all of the votes</strong>). When all of the systems have been summarized, you may count how many votes each <strong>remaining</strong> candidate has. <strong>See the examples for details.</strong></p>
<p>If a candidate has <strong>more than</strong> half of all the votes, declare them winner and <strong>print</strong> the message (<strong>3 lines</strong>):</p>
<p><em>&lt;winner name&gt;</em> wins with <em>&lt;number of votes&gt;</em> votes</p>
<p>Runner up: <em>&lt;second place name&gt;</em></p>
<p><em>&lt;list of systems, won by runner up&gt;</em></p>
<p><strong>Order</strong> the systems by number of votes, <strong>descending</strong>. See the examples for formatting details on the list of systems.</p>
<p>It&rsquo;s possible that a <strong>single candidate won all of the systems</strong>, in that case, print the following message (2 lines):</p>
<p><em>&lt;winner name&gt;</em> wins with <em>&lt;number of votes&gt;</em> votes</p>
<p><em>&lt;winner name&gt;</em> wins unopposed!</p>
<p>If nobody got majority, there will be a runoff, so print this message (<strong>single line</strong>):</p>
<p>Runoff between <em>&lt;candidate 1&gt;</em> with <em>&lt;percent&gt;</em>% and <em>&lt;candidate 2&gt;</em> with <em>&lt;percent&gt;</em>%</p>
<p>Print the candidate with more votes first and <strong>round down the percentages in this message</strong>. <strong>See the examples.</strong></p>
<h3>Input</h3>
<p>You will receive an <strong>array of objects</strong> with properties as shown above.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> a message, depending on the outcome of the election, as instructed above.</p>
<h3>Constraints</h3>
<ul>
<li>The input objects will <strong>always be valid</strong></li>
<li>There will always be <strong>at least two</strong> candidates</li>
<li>A system may vote for a single candidate (ballot only for one candidate)</li>
<li>There will never be a tie <strong>within a system</strong></li>
<li>There never be a tie in the <strong>final count</strong> (equal votes for the top two candidates)</li>
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
<p>[ { <strong>system</strong>: 'Theta', <strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 10 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', <strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 200 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', <strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 120 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;<strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 15 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', <strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 60 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;<strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 150 } ]</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Space Cow wins with 380 votes</p>
<p>Runner up: Flying Shrimp</p>
<p>Tau: 165</p>
<p>Theta: 10</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>When we collect all the ballots, for system Theta, Flying Shrimp is the only candidate with 10 votes. In system Sigma, Flying Shrimp has 120 votes, while Space Cow has 260. <strong>Space Cow has the most votes in Sigma, so she wins all of the votes for that system (380).</strong> In Tau, Shrimp has 150, Cow 15 &ndash; Flying Shrimp gets all 165.</p>
<p>We&rsquo;ve summarized the systems, so we can count the <strong>final results</strong> &ndash; Flying Shrimp with 175 and Space Cow with 380. 380 is more than half of the total (555), so we declare her winner. At the end, we print all systems that Flying Shrimp won, ordered by number of votes.</p>
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
<p>[ { <strong>system</strong>: 'Tau', &nbsp;&nbsp;&nbsp;&nbsp;<strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 150 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;&nbsp;&nbsp;<strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 100 },</p>
<p>&nbsp; { <strong>system</strong>: 'Theta', &nbsp;&nbsp;<strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 10 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', &nbsp;&nbsp;<strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 200 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', &nbsp;&nbsp;<strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 75 },</p>
<p>&nbsp; { <strong>system</strong>: 'Omicron', <strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 50 },</p>
<p>&nbsp; { <strong>system</strong>: 'Omicron', <strong>candidate</strong>: 'Octocat', &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 75 } ]</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Runoff between Space Cow with 43% and Flying Shrimp with 37%</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Space Cow wins Theta (10) and Sigma (275). Flying Shrimp wins Tau (250). Octocat wins Omicron (125). There is no majority, so we take the two candidates with most votes, and send them to a runoff election. Note all <strong>percentages</strong> are <strong>rounded down</strong>.</p>
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
<p>[ { <strong>system</strong>: 'Theta', <strong>candidate</strong>: 'Kim Jong Andromeda', <strong>votes</strong>: 10 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;<strong>candidate</strong>: 'Kim Jong Andromeda', <strong>votes</strong>: 200 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;<strong>candidate</strong>: 'Flying Shrimp', &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 150 } ]</p>
</td>
</tr>
<tr>
<td width="1391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="1391">
<p>Kim Jong Andromeda wins with 360 votes</p>
<p>Kim Jong Andromeda wins unopposed!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>