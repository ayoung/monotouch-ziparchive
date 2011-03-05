SOURCES = \
	ziparchive.cs

all: monotouch-ziparchive.dll

monotouch-ziparchive.dll: $(SOURCES)
	/Developer/MonoTouch/usr/bin/btouch -out=monotouch-ziparchive.dll ziparchive.cs