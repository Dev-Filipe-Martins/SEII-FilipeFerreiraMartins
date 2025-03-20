APPS = ./apps
BIN = ./bin
INCLUDE = ./include
OBJ = ./obj
SRC = ./src

all: libed clean_apps myapps
#all: libed myapps
#all: libed myapps
#	gcc -c $(SRC)/float_vector.c -I $(INCLUDE) -o $(OBJ)/float_vector.o
#	gcc -c $(SRC)/mytime.c -I $(INCLUDE) -o $(OBJ)/mytime.o
#	gcc $(APPS)/app.c $(OBJ)/*.o -I $(INCLUDE) -o $(BIN)/app
#	gcc $(APPS)/app_com_mytime.c $(OBJ)/*.o -I $(INCLUDE) -o $(BIN)/app_com_mytime
#	echo "Oi oi OI"

libed: \
	$(OBJ)/float_vector.o \
	$(OBJ)/mytime.o
# 	float_vector.o \
# 	mytime.o
#	gcc -c $(SRC)/float_vector.c -I $(INCLUDE) -o $(OBJ)/float_vector.o
#	gcc -c $(SRC)/mytime.c -I $(INCLUDE) -o $(OBJ)/mytime.o

myapps: \
	$(BIN)/app \
	$(BIN)/app_com_mytime
#	gcc $(APPS)/app.c $(OBJ)/*.o -I $(INCLUDE) -o $(BIN)/app
#	gcc $(APPS)/app_com_mytime.c $(OBJ)/*.o -I $(INCLUDE) -o $(BIN)/app_com_mytime

$(OBJ)/%.o: $(SRC)/%.c $(INCLUDE)/%.h
	gcc -c $< -I $(INCLUDE) -o $@

$(BIN)/%: $(APPS)/%.c
	gcc $< $(OBJ)/*.o -I $(INCLUDE) -o $@

run:
	$(BIN)/app
#	./bin/app
#	echo "Rodando um Programa"

# hello:
# 	echo "Hello!"
# 	tree .

clean:
	rm -rf $(BIN)/* $(OBJ)/*
#	rm -rf ./bin/* ./obj/*

clean_apps:
	rm -rf $(BIN)/*

