help:
	#Makefile to build, run, and clean C# and Java Gctest 
	#'buildcs', 'runcs', and 'cleancs'
	#'buildjava', 'runjava', and 'cleanjava' 

all: allcs alljava
	
allcs: cleancs buildcs runcs
	
alljava: cleanjava buildjava runjava
	

buildcs:
	csc Gctest.cs
runcs:
	./Gctest
cleancs:
	rm -f Gctest.exe Gctest

buildjava:
	javac Gctest.java
runjava:
	java Gctest
cleanjava:
	rm -f Gctest.class A.class B.class C.class