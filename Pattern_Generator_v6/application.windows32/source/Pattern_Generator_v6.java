import processing.core.*; 
import processing.data.*; 
import processing.event.*; 
import processing.opengl.*; 

import processing.pdf.*; 

import java.util.HashMap; 
import java.util.ArrayList; 
import java.io.File; 
import java.io.BufferedReader; 
import java.io.PrintWriter; 
import java.io.InputStream; 
import java.io.OutputStream; 
import java.io.IOException; 

public class Pattern_Generator_v6 extends PApplet {


// ------message------ denotes the beginning of a large process

// terminology:
// shape: one of these things vvvv                                   
//                              *****                         
//                            *     *                             
//                          *       *                             
//                        *       *                             
//                        *     *                                  
//                        *****     
// tile: a group of 5-15 shapes, each with differnt coordinates, colours and thicknesses 



// variables for controlling aspects of pattern display and generation that are not available in the UI
// sets whether the shapes are filled with colour or just outlined
boolean stroke = true;
// sets whether shapes are displayed with normal thickness or just thickness = 1
boolean thck1 = false;
// if true, white background
boolean wback = false;
// if true, draw the underlying grid
boolean drawGrid = false;
// set the stroke weight, dont set too high
int strokeWeight = 1;
// set tile count
int tileCount = 10, tileCountMax = 12, tileCountMin = 8; // is really sqrt(tileCount) (odd numbers might produce weird results



// create array for reading of data
String[] lines;
// create and initialise colour array
int[] colours = new int[5] ; 
// create and initialise max and min shape, grid size and repetition configuration variables
int maxShapes, minShapes, gridSize, repC = 0;
// create and initialise saveFrame boolean 
boolean saveFrame = false;
// create and initialise shape Array
ArrayList<Shape> shapes = new ArrayList<Shape>();
// create and initialise seed array
ArrayList<String> seeds = new ArrayList<String>();
// create curSeed string
String curSeed;
// create index int for retrieving seeds from array
int index = 0;
// import pdf library 


// setup function
public void setup() {
  // set environment variables
  
  frameRate(30);
  // read in data 
  lines = loadStrings("../../Input_Parameters/Input_Parameters/bin/Debug/data.txt");
  // import colours to array
  for (int i = 0; i < 5; i++) {
    // split up string using commas as places to split
    String[] rgb = split(lines[i], ',');
    //println(rgb[0] + "and" + rgb[1]); < testing 
    //println(Integer.parseInt(rgb[1])*2); < testing
    // create a proxy colour and give it rgb values from the comma seperated values mentioned above
    int cp = color(Integer.parseInt(rgb[0]), Integer.parseInt(rgb[1]), Integer.parseInt(rgb[2]));
    // set the current index of the colour array to the proxie's value(s)
    colours[i] = cp;
  }
  // import max and min sizes to corresponding variables
  maxShapes = Integer.parseInt(lines[5]);
  //println(maxShapes); < testing 
  minShapes = Integer.parseInt(lines[6]);
  // import grid size and repetition configuration to corresponding variables
  gridSize = Integer.parseInt(lines[7]);
  repC = Integer.parseInt(lines[8]);
  //gridSize = 10; < testing

  // adding shapes manually for testing purposes
  //shapes.add(new Shape(colours[0], 1, 3, 4, 6, 1));
  //shapes.add(new Shape(colours[2], 0, 0, 10, 10, 3));
  //shapes.add(new Shape(colours[2], 5, 1, 2, 4, 1));
  //shapes.add(new Shape(colours[2], 5, 1, 2, 5, 3));
  //float i = gradient(0, 0, 1, 2); < testing
  //println(i); < testing
  //returnNewSeed(); < testing

  // add initial seed to populate array
  seeds.add(returnNewSeed());
}

// draw function
public void draw() {
  // check if user has requested to save frame, and begin recording drawing output of the program if they have
  if (saveFrame == true) {
    beginRecord(PDF, "../../saves/Export####.pdf");
  }
  // draw background
  if (wback) {
    background(255);
  } else {
    background(20);
  }
  // draw underlying grid if necessary
  if (drawGrid == true) {
    for (int i = 0; i < tileCount; i++) {
      for (int j = 0; j < tileCount; j++) {
        stroke(255);
        line(0, (1000/tileCount)*j, 1000, (1000/tileCount)*j);
      }
      stroke(255);
      line((1000/tileCount)*i, 0, (1000/tileCount)*i, 1000);
    }
  }
  // set curSeed to seed at current array index
  curSeed = seeds.get(index);

  // ------read current seed and decode it into the shape array------ 
  // create a variable to store the number of shapes in the given tile as read from the beginning of the seed (the 2 digits before 'd')
  int numShapes = Integer.parseInt(curSeed.substring(0, 2));
  //println(numShapes); < testing
  // remove all entries from shape array if there are any 
  if (shapes.size() > 0) {
    for (int i = 0; i < shapes.size() + 1; i++) {
      shapes.remove(0);
    }
  }
  // add all shapes that are encoded in the current seed to the shapes array
  for (int i = 0; i < numShapes; i++) {
    int seedLength = 19;
    // decode colour channels into integers
    int r = Integer.parseInt(curSeed.substring(3 + seedLength*i, 6 + seedLength*i));
    int g = Integer.parseInt(curSeed.substring(6 + seedLength*i, 9 + seedLength*i));
    int b = Integer.parseInt(curSeed.substring(9 + seedLength*i, 12 + seedLength*i));
    // combine colour chennels into colour c
    int c = color(r, g, b);
    // decode coordinates & thickness into integers
    int x1, y1, x2, y2, thickness;
    x1 = Integer.parseInt(curSeed.substring(12 + seedLength*i, 14 + seedLength*i));
    y1 = Integer.parseInt(curSeed.substring(14 + seedLength*i, 16 + seedLength*i));
    x2 = Integer.parseInt(curSeed.substring(16 + seedLength*i, 18 + seedLength*i));
    y2 = Integer.parseInt(curSeed.substring(18 + seedLength*i, 20 + seedLength*i));
    thickness = Integer.parseInt(curSeed.substring(20 + seedLength*i, 22 + seedLength*i));
    // add shape to shape array using data that has just been decoded
    shapes.add(new Shape(c, x1, y1, x2, y2, thickness));
  }
  //test = new(Shape) < testing 
  // ------draw all shapes to screen------
  // create increment variable and set it to be equal to 0
  int inc = 0;
  // !quadruple nested control structures ahead!
  // iterate through each tile position and draw the tile there
  for (int i = 0; i < tileCount; i++) {
    pushMatrix();
    // translate down before drawing
    translate(0, i*(width/tileCount));
    for (int j = 0; j < tileCount; j++) {
      pushMatrix();
      // translate across before drawing
      translate(j*(width/tileCount), 0);
      // depending on which repetition configuration has been chosen by the user, flip axes or dont flip axes 
      if (repC == 1) {
        // repC 1: do nothing as tile can just be drawn normally
      } else if (repC == 2) {
        // repC 2: every second tile must be flipped in the y-axis
        if (inc % 2 == 1) {
          // do nothing
        } else {
          // translate across and flip (flip in y-axis)
          translate((width/tileCount), 0);
          scale(-1, 1);
        }
      } else {
        // repC 4: tiles are flipped such that the pattern (x,y), (-x,y), (x,-y) , (-x,-y) is repeated 
        if (inc % 4 == 1) {
          // do nothing
        } else if (inc % 4 == 2) {
          // translate across and flip (flip in y-axis)
          translate((width/tileCount), 0);
          scale(-1, 1);
        } else if (inc % 4 == 3) {
          // translate down and flip (flip in x-axis)
          translate(0, (width/tileCount));
          scale(1, -1);
        } else if (inc % 4 == 0) {
          // translate across and flip (flip in both axes)
          translate((width/tileCount), (width/tileCount));
          scale(-1, -1);
        }
      }
      inc++;
      // draw all shapes in tile
      for (int k = 0; k < shapes.size(); k++) {
        shapes.get(k).disp();
        //println(shapes.size()); < testing
      }
      popMatrix();
    }
    popMatrix();
  }
  //fill(colours[0]); < testing
  //rect(0,0,200,200); < testing
  /* testing vvvv
   for (int i = 0; i < seeds.size(); i++) {
   println(i + ". " + seeds.get(i));
   }
   */
  // if user has asked to save the pattern, end the recording and reset the status of saveFrame
  if (saveFrame == true) {
    endRecord();
    saveFrame = false;
    println("Frame Saved");
  }
}
// shape class
class Shape {
  // create variables to be used in shape config and drawing
  int x1; 
  int y1; 
  int x2; 
  int y2; 
  int thickness; 
  int col; 
  int colNum; 
  float d; 

  // create constructor function so that new "Shape"s can be created
  Shape (int c_, int x1_, int y1_, int x2_, int y2_, int thickness_) {
    // pass all variables 
    this.col = c_; 
    this.thickness = thickness_; 
    x1 = x1_; 
    y1 = y1_; 
    x2 = x2_; 
    y2 = y2_; 
    //thickness = floor(random(0, 2*d/3) + 1); < testing
  }

  // shape display function
  public void disp() {
    pushMatrix(); 
    strokeWeight(strokeWeight); 
    fill(this.col); 
    stroke(this.col); 
    if (stroke) {
      noFill();
    } else {
      noStroke();
    }
    int x1_ = x1; 
    int x2_ = x2; 
    int y1_ = y1; 
    int y2_ = y2;
    //thickness = 1; < testing
    float scale = (1000/PApplet.parseFloat(tileCount))/PApplet.parseFloat(gridSize);
    //println(scale); < testing
    // drawing the arrows depending on their orientation
    if (x1 > x2 && y1 > y2) {
      beginShape(); 
      vertex(x2_ * scale, y2_ * scale); 
      vertex(x2_ * scale, (y2_ + thickness) * scale); 
      vertex((x1_ - thickness) * scale, y1_ * scale); 
      vertex(x1_ * scale, y1_ * scale); 
      vertex(x1_ * scale, (y1_ - thickness) * scale); 
      vertex((x2_ + thickness) * scale, y2_ * scale); 
      endShape(CLOSE);
    } else if (x2 > x1 && y1 > y2) {
      beginShape(); 
      vertex(x2_ * scale, y2_ * scale); 
      vertex(x2_ * scale, (y2_ + thickness) * scale); 
      vertex((x1_ + thickness) * scale, y1_ * scale); 
      vertex(x1_ * scale, y1_ * scale); 
      vertex(x1_ * scale, (y1_ - thickness) * scale); 
      vertex((x2_ - thickness) * scale, y2_ * scale); 
      endShape(CLOSE);
    } else if (x1 > x2 && y2 > y1) {
      beginShape(); 
      vertex(x2_ * scale, y2_ * scale); 
      vertex(x2_ * scale, (y2_ - thickness) * scale); 
      vertex((x1_ - thickness) * scale, y1_ * scale); 
      vertex(x1_ * scale, y1_ * scale); 
      vertex(x1_ * scale, (y1_ + thickness) * scale); 
      vertex((x2_ + thickness) * scale, y2_ * scale); 
      endShape(CLOSE);
    } else if (x2 > x1 && y2 > y1) {
      beginShape(); 
      vertex(x1_ * scale, y1_ * scale); 
      vertex(x1_ * scale, (y1_ + thickness) * scale); 
      vertex((x2_ - thickness) * scale, y2_ * scale); 
      vertex(x2_ * scale, y2_ * scale); 
      vertex(x2_ * scale, (y2_ - thickness) * scale); 
      vertex((x1_ + thickness) * scale, y1_ * scale); 
      endShape(CLOSE);
    }
    popMatrix();
  }
}


// a function that returns the gradient between 2 points
public float gradient(int x1, int y1, int x2, int y2) {
  float g;
  float x1_ = x1;
  float x2_ = x2;
  float y1_ = y1;
  float y2_ = y2;
  g = (y2_-y1_)/(x2_-x1_);
  return g;
}


// handle the 'keypressed' event
public void keyPressed() {
  if (keyCode == LEFT && index > 0) { // if left key pressed and not currently at index 0, decrement index
    index--;
  } else if (keyCode == RIGHT && ((index + 1) == seeds.size())) { // if right key pressed and currently at greatest index of seeds array, create a new entry to seeds array and increment index
    seeds.add(returnNewSeed());
    index++;
  } else if (keyCode == RIGHT && ((index + 1) != seeds.size())) { // if right key pressed and NOT currently at greatest index of seeds array, increment index but DO NOT create a new entry to seeds array
    index++;
  } else if (key == 's') { // if 's' key pressed, tell process to save the next frame
    saveFrame = true;
  } else if (key == 'c') { // if 'c' key pressed, write current seed to text file
    PrintWriter output;
    output = createWriter("../../saves/seeds.txt"); 
    output.println(seeds.get(index));
    output.close();
  } else if (key == 'x') { // if 'x' key pressed, flip stroke setting
    stroke = !stroke;
  } else if (key == 't') { // if 't' key pressed, flip thickness setting
    thck1 = !thck1;
  } else if (key == 'b') { // if 'b' key pressed, flip background colour setting
    wback = !wback;
  } else if (key == 'g') { // if 'g' key pressed, flip grid drawing setting
    drawGrid = !drawGrid;
  } else if (key == 'd') { // if 'w' key pressed, increment tile count by 1 as long as its not at tileCountMax
    if (tileCount < tileCountMax) {
      tileCount++;
    }
  } else if (key == 'a') { // if 'a' key pressed, decrement tile count by 1 as long as its not at tileCountMin
    if (tileCount > tileCountMin) {
      tileCount--;
    }
  } 
  
}

// function to return a new seed based on the parsed parameters
public String returnNewSeed() {
  String st = "";
  //println(maxShapes + " < max shapes"); < testing
  //creating a new tile
  //select number of shape between min and max
  int t = floor(random(minShapes, maxShapes + 1)); 
  //println("t " + t); < testing
  // for all shapes, assign a colour and 2 points
  for (int i = 0; i < t; i++) {
    //finding random colours and putting them in seed
    int r = floor(random(0, 5));
    String c1 = to3digit(floor(red(colours[r])));
    String c2 = to3digit(floor(green(colours[r])));
    String c3 = to3digit(floor(blue(colours[r])));
    // add these to the string s1
    String s1 = c1 + c2 + c3;
    // initialise xy for 2 points
    int x1, y1, x2 = 0, y2 = 0;
    // assign random values to x1 and y1 that are inside the grid
    x1 = floor(random(0, gridSize+1));
    y1 = floor(random(0, gridSize+1));
    // check if gradient between (x1,y1) and (x2,y2) is = 1 or -1 and generate random values for (x2,y2) until this condition is met 
    while (abs(gradient(x1, y1, x2, y2)) != 1) {
      x2 = floor(random(0, gridSize+1)); 
      y2 = floor(random(0, gridSize+1));
    }
    int thickness;
    if (!thck1) {
      // generate a thickness value that is no greater than the distance between 2 points divied by root 2
      float d = dist(x1, y1, x2, y2)/sqrt(2);
      thickness = floor(random(1, d+1));
    } else {
      // set the thickness value to be equal to 1
      thickness = 1;
    }
    // create string s2 and give it the (x,y) values of the points 
    String s2 = to2digit(x1) + to2digit(y1) + to2digit(x2) + to2digit(y2) + to2digit(thickness);
    // join the 2 strings 
    st = st + s1 + s2;
  }
  st = to2digit(t) + "d" + st;
  println(st);
  //return string 
  return(st);
}
// function that takes in int as a input and outputs a 3-digit string
public String to3digit(int i) {
  if (i < 10) {
    return("00" + Integer.toString(i));
  } else if (i < 100) {
    return("0" + Integer.toString(i));
  } else {
    return(Integer.toString(i));
  }
}
// function that takes in int as a input and outputs a 2-digit string
public String to2digit(int i) {
  if (i < 10) {
    return("0" + Integer.toString(i));
  } else {
    return(Integer.toString(i));
  }
}
  public void settings() {  size(1000, 1000); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "Pattern_Generator_v6" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
