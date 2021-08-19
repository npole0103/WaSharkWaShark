import json
import sys

def filter1():
    j_list = []
    for j in range(len(json_data)):
        if (path["tcp"]["tcp.stream"] == json_data[j]["_source"]["layers"]["tcp"]["tcp.stream"]):
            j_list.append(j)
    filter2(j_list)

def filter2(j_list):
    for i in j_list:
        print_data(i)

def print_data(j):
    path = json_data[j]["_source"]["layers"]
    #print('nxtseq: {0}'.format(path["tcp"]["tcp.nxtseq"]))
    #print('ack: {0}'.format(path["tcp"]["tcp.ack"]))
    
    print("******************packet**********************")
    print(json.dumps(path["http"], indent="\t"))
       
    print()
    print()

    n = j
    return n


with open('./httptest.json', 'r', encoding='UTF8') as f:
    json_data = json.load(f)

i = int(sys.argv[1])
path = json_data[i]["_source"]["layers"]

filter1()
