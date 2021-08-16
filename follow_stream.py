import json

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
    print('nxtseq: {0}'.format(path["tcp"]["tcp.nxtseq"]))
    print('ack: {0}'.format(path["tcp"]["tcp.ack"]))
    
    print("****************************************")
    print(json.dumps(path["http"], indent="\t"))
       
    print()
    print()

    n = j
    return n


with open('./httptest.json', 'r', encoding='UTF8') as f:
    json_data = json.load(f)

i = 0   #내가 선택한 패킷 번호
path = json_data[i]["_source"]["layers"]

filter1()


'''
    if ("http.request" in path["http"]) and (path["http"]["http.request"] == "1"):
        print("=================================================================")
        print(list(path["http"].keys())[0])
        #print('{0} {1} {2}'.format(json_data[i]["_source"]["layers"]["http"]["GET / HTTP/1.1\\r\\n"]["http.request.method"], \
        #   json_data[i]["_source"]["layers"]["http"]["GET / HTTP/1.1\\r\\n"]["http.request.uri"], json_data[i]["_source"]["layers"]["http"]["GET / HTTP/1.1\\r\\n"]["http.request.version"]))
        print('Host: {0}'.format(path["http"]["http.host"]))
        print('Connection: {0}'.format(path["http"]["http.connection"]))
        print('Cache-Control: {0}'.format(path["http"]["http.cache_control"]))
        print('User-Agent: {0}'.format(path["http"]["http.user_agent"]))
        print('Accept: {0}'.format(path["http"]["http.accept"]))
        print('Accept-Encoding: {0}'.format(path["http"]["http.accept_encoding"]))
        print('Accept-Language: {0}'.format(path["http"]["http.accept_language"]))
        print('Cookie: {0}'.format(path["http"]["http.cookie"]))
    elif "data" in path["http"]:
        print('Data: {0}'.format(path["http"]["data"]["data.data"]))
'''
