# CSS Selector

Selectors are used for declaring the HTML elements to which a style will apply.

The most common selectors are:

* all elements with a specific HTML tag (e.g., p, h1)
* elements specified by the following attributes:
    * id (these are preceded by # in CSS)
        * These must be unique and can only be used once on your page.
    * class (these are preceded by .  in CSS)
        *  These can be used multiple times to share repeating CSS code.
## Declaration Block
A declaration block is a list of declarations contained within braces. Each individual declaration consists of a property, a colon (":"), and a value. If a block has multiple declarations, they must be separated by a semi-colon(";").

Examples: In the below examples, **p**, **#important**, and **.info** are **selectors**. **Color**, **font-size**, **background-color**, and **border** are **properties**.

``` css
p{                   
  color: blue; 
}
```

``` css
#important{
  font-size: 36px;
}
```
``` css
.info{
  background-color: green;
  border: 1px solid black;
}
```
Now that we know a little more about how to use selectors, let’s make a general list of the internal priorities for CSS:

1. element (1 point)
2. .class (10 points)
3. #id (100 points)

This is the default priority order. In addition to this, specificity will also count, for example,  ul li will override li. W3C has made a decent table over how you should calculate internal weight:
```
li            {...}  /* a=0 b=0 c=1 -> specificity =   1 */
ul li         {...}  /* a=0 b=0 c=2 -> specificity =   2 */
ul ol li      {...}  /* a=0 b=0 c=3 -> specificity =   3 */
li.red        {...}  /* a=0 b=1 c=1 -> specificity =  11 */
ul ol li.red  {...}  /* a=0 b=1 c=3 -> specificity =  13 */
#list         {...}  /* a=1 b=0 c=0 -> specificity = 100 */
```
* a represents the number of #id attributes in the selector
* b represents the number of class attributes
* c represents the number of tag names


# Styling ELements
Below are some of the most common styling properties that will affect all elements. This is not a definitive list!!

## width | height:
The width and height properties are used to determine the size of your elements. The values can be expressed in pixels (px) and percentage (%) (percentage is responsive). 

When you want your element to resize ie: images, you can size just one property (width or height) and the other will adjust appropriately to keep the relative dimensions of the image.
``` css
  a {
    width: 25px;
  }
  div {
    width: 100%;
    height: 200px;
  }
  img {
    width: 250px;
  }
```

## overflow:
This property determines what should happen when the content inside of a container is too much for the container size. You can set the container to hide the additional information that does not fit, show the information no matter what, or have a scroll bar added to the element so the content is contained but still viewable.
``` css
  div {
    overflow: scroll;
  }
```
## background:
The background property can modify the background of an element all in one line. This is a shorter version than splitting each property on its own line of code. The color can be defined using hex, rgb or semantic code.
``` css
  p {
    background: #ffffff url("cherries.png") no-repeat fixed center;
  }
```

## background-color | background-image | background-position | background-size | background-repeat:
These background properties adjust the background by property type. Like background, background-color can be defined using hex, rgb or semantic code.
``` css
  p {
    background-color: blue;
  }
  div {
    background-image: url("cherries.png");
    background-position: center;
    background-size: auto;
    background-repeat: no-repeat;
  }
```

## border:
This property adjusts all border elements in one line. The first value is the border thickness. The second value is the border type. The third value is the border color. The color can be hex, rgb or semantic code.

The border property can also be broken down into separate lines using border-width, border-style and border color. Additionally, you can select very specifically which border you want to style by using border-top, border-bottom, border-right, border-left.
``` css
  button {
    border: 2px dotted green;
  }
  div {
    border: 1px solid #000000;
  }
  p {
    border-right: 1px groove rgb(100,100,100);
    border-left: 1px groove rgb(200,200,200);
  }
  ```

## border-radius
This property allows the corners of your border to be given a rounded appearance. The values can be set using px or %.

 ``` css
  button {
    border-radius: 5px;
  }
  ```

# Styling Text
## color:
The text color is specified using the color property. The value of the color property can be expressed using hex, RGB or semantic code.
``` css
  p {
    color: #ffffff;
  }
  a {
    color: rgb(255, 255, 255);
  }
  span {
    color: white;
  }
```

## text-align:
Text can be centered, or aligned to the left or right, or justified. This property will only work if the property is also display block.
``` css
  h1 {
    text-align: center;
  }
```
## text-decoration:
The text-decoration property is used to add and remove underlines, overlines, and line-throughs.
``` css
  a {
    text-decoration: none;
  }
```

## Font

### font-family:
The font-family property specifies the font style to use for an element. There are two types of font family names:

There are fonts that are installed on pretty much all systems and so are termed web safe fonts because you can with some certainty know it will look the same regardless of the system the user has. Some of these are; Verdana, Arial, Trebuchet MS, Times New Roman, Georgia, Andale Mono, Courier New, Comic Sans, and Impact.
```css
  p {
    font-family: "helvetica neue", arial, verdana, sans-serif;
  }
```
Font-family allows for multiple options to be entered where the browser goes through them from left to right until it finds a font that is installed on the system which can be used. This means that you always want to make sure you have a generic-family option as your last value so that if none of the others can be found, the browser will use the system default for the family specified.

The browser searches for Helvetica Neue on the user's system and uses this if it finds it.
If Helvetica Neue isn't found, the browser searches for Arial on the user's system and uses it if it finds it.
If Arial isn't found, we'll use Verdana.
As a last resort, if none of the fonts in the font stack are found we fall back to sans-serif, which basically instructs the browser to use whatever the system's default sans-serif font is. You don't know exactly what will be used in this eventuality, but at least this is better than ending up with the browser default, Times new roman, which is a serif font!
Note that fonts with more than one word in their name need surrounding in quotes.

## font-size:
The font-size property values can be expressed in four different units pt, px, em, %. pt and px (point and pixel) are considered static size values and will not adjust properly when resizing your page. em and % (responsive measure and percent) however will resize and are what most developers recommend using. Below is a drop-down chart showing the approximate equivalents between the four units.(**Note** not intended to update code)


Point | Pixel | Em | Percent
``` css
  h3 {
    font-size: 10pt;
  }
  p {
    font-size: 14px;
  }
  a {
    font-size: 1.2em;
  }
  span {
    font-size: 80%;
  }
```
## font-style
This property controls the slanted emphasis of the text. Some text may have an italic property built into the font and so selecting italic would be fine. For fonts that do not have an italic style, the value oblique can be used to mimic italicized text.
``` css
  span {
    font-style: italic;
  }
```
## font-weight
This property defines the thickness of a character line. normal is often the default value. The values can be set numerically or semantically.
``` css
normal
  p {
    font-weight: bold;
  }
  span {
    font-weight: 600;
  }
```
``` html
<h1>Hello <div>World</div> </h1>copy
```
Above by default would put 'World' on a new line.  However if you wanted World to show up in the same line, you could instead do

 ``` html
<h1>Hello <span>World</span> </h1> 
```
Then in the css, you could have done something like this to just highlight the word 'World':

```css 
h1 span {
   font-weight: bold;
   color: blue;
} 
```
<!-- # Inspect Element -->

<!-- # Lego Concept -->
# Box Model
# Display Property
# Justify & Align
