MAIN_FILE = Earthpapers

REFS = /reference:System.Drawing.dll /reference:System.Windows.Forms.dll /reference:System.Net.Http.dll /reference:mscorlib.dll\

CSHARP_SOURCE_FILES = $(wildcard *.cs)

CSHARP_COMPILER = mcs

EXECUTABLE = $(MAIN_FILE).exe

all: $(EXECUTABLE)

$(EXECUTABLE): $(CSHARP_SOURCE_FILES)
	@ $(CSHARP_COMPILER) $(REFS) $(CSHARP_SOURCE_FILES)

run: all
	mono $(EXECUTABLE)

clean:
	@ rm -f 

remake:
	@ $(MAKE) clean
	@ $(MAKE)