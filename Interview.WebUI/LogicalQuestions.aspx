<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogicalQuestions.aspx.cs" Inherits="Interview.WebUI.LogicalQuestions" MasterPageFile="~/Exam.Master" Theme="MySkin"%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style="color: #000000; font-size: small;">
        <pre style="color: #000000;font-size:medium;background-color:lightgreen;">
<h3><u><b>Introduction:</b></u></h3>
<b>Aptitude Test</b> is conducted to Test candidate’s Problem solving ability and to test how efficiently a student can respond to a task or a situation and their 
communication skills.The area those are generally tested are Numerical Ability and Quantitative Aptitude, Logical reasoning, Verbal Ability (General English) ,
Data sufficiency and Interpretation.

<h4><u><b>Quantitative Aptitude</b></u></h4>
In this section of Quantitative Aptitude candidate is asked MCQ from most of the topicscovered in high school along with some advanced topics. The various topics from 
which questions may be asked are Number system, Averages, Ratio and Proportion, Percentages, Time and distance, Mixture and allegation, permutation and combination , 
probability, geometry and algebra.

<h4><u><b>Verbal Ability</b></u></h4>
This area tests candidate’s reading ability and level of Grammar. The type of questions that may be asked in verbal ability section include Spotting Errors, 
Sentence Improvements, Para- Jumbled, Reading Comprehension, idioms and phrases, letter writing, essay writing.

<h4><u><b>Analytical and Logical Reasoning</b></u></h4>
This section is asked to test candidate’s logical and analytical ability. The questions are generally asked from Coding- Decoding, Series, Puzzles, Cause and effect, 
Direction and Ranking.

<h4><u><b>Data Interpretation and Data Sufficiency</b></u></h4>
In the section of Data Interpretation and Sufficiency , Data is presented inthe form of Table chart, bar graph , line graph etc. Candidate has to go through the 
questions given below and solve the question by interpreting the data.

<h3><u><b>Campus Recruitment Test Syllabus</b></u></h3>
<h3><b>QUANTITATIVE APTITUDE		          VERBAL ABILITY		             LOGICAL REASONING</b></h3>
Number System			                                Sentence Improvement                                                Coding Decoding
Percentage			                                Reading Comprehension			                            Sitting Arrangements
Ratio and Proportion		                                Cloze Test				                            Data sequence/Calendars
Partnership			                                Sentence Re- Arrangements		                            Direction Sense Test
Profit & Loss			                                Fill in the Blanks			                            Blood Relations
Simple & Compound Interest	                                Theme Detection				                            Syllogism
Alligation & Mixture		                                Analogy					                            Series
Average				                                <b>VOCAB</b>	       	                                                    Analogy Classification
Time & Distance			                                Synonyms   				                            Alphabet Test
Time and Work			                                Words often confused & misused   	                            Clocks
Mensuration 2D & 3D		                                <b>GRAMMAR</b>			                                            Puzzle Test
Permutation and Combination    	                                Noun					                            Statements and Arguments
Probability			                                Pronoun					                            Non Verbal Reasoning
Co-ordinate Geometry		                                Adjectives 				                            Cubes and dice
Inequalities			                                Tenses  	 
Functions			                                Verb  	 
Logarithm			                                Subject + Verb Agreement	 
Set Theory			                                Adverb  	 
Progressions			                                Preposition   	 
Quadratic equations		                                Article   	 
Surds				                                Conjunction    
        <br />
        <asp:Button ID="btnTakeTest" runat="server" CssClass="btn btn-primary" OnClick="btnTakeTest_Click" Text="Take Test" />
</pre>

    </form>
</asp:Content>