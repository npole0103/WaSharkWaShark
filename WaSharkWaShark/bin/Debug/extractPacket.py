import json
import os

from typing import OrderedDict

def is_json_key_present(json, key):
    try:
        buf = json[key]
    except KeyError:
        return False

    return True

def createFolder(directory):
    try:
        if not os.path.exists(directory):
            os.makedirs(directory)
    except OSError:
        print ('Error: Creating directory. ' +  directory)

createFolder('RawPacket')
createFolder('JsonView')

with open ("Main.json", "r", encoding="utf-8") as json_file:
    json_data = json.load(json_file)

count = 1
result_json = []
temp_domain = {}

for i in json_data:
    result = OrderedDict()
    result["No"] = '%s'%count
    result["Time"] = i["_source"]["layers"]["frame"]["frame.time"]
    result["SrcIp"] = i["_source"]["layers"]["ip"]["ip.src"]
    result["SrcMac"] = i["_source"]["layers"]["eth"]["eth.src"]
    result["SrcDomain"] = ""
    if(is_json_key_present(i["_source"]["layers"]["http"],"http.response.line")):
        try:
            result["SrcDomain"] = temp_domain[i["_source"]["layers"]["tcp"]["tcp.stream"]]
        except KeyError:
            continue
    result["DesIp"] = i["_source"]["layers"]["ip"]["ip.dst"]
    result["DesMac"] = i["_source"]["layers"]["eth"]["eth.dst"]
    result["DesDomain"] = ""
    if(is_json_key_present(i["_source"]["layers"]["http"],"http.request.line")):
        result["DesDomain"] = i["_source"]["layers"]["http"]["http.host"]
        temp_domain[i["_source"]["layers"]["tcp"]["tcp.stream"]] = i["_source"]["layers"]["http"]["http.host"]
    result["Length"] = i["_source"]["layers"]["frame"]["frame.len"]
    result["URI"] = ""
    if(is_json_key_present(i["_source"]["layers"]["http"],"http.response.line")):
        result["URI"] = i["_source"]["layers"]["http"]["http.response_for.uri"]
    if(is_json_key_present(i["_source"]["layers"]["http"],"http.request.line")):
        result["URI"] = i["_source"]["layers"]["http"]["http.request.full_uri"]

    f = open("RawPacket/%s.txt"%result["No"], 'w', encoding="utf-8")
    data = "".join("{:3x}".format(ord(ch)) for ch in str(i) if 0x00 <= ord(ch) <= 0xff)
    f.write(data)
    f.close()

    f = open("JsonView/%s.txt"%result["No"], 'w', encoding="utf-8")
    data = str(json.dumps(i, ensure_ascii=False, indent='\t'))
    f.write(data)
    f.close()

    result["RawPacket"] = "RawPacket"
    result["JsonView"] = "JsonView"

    count += 1
    result_json.append(result)

print(json.dumps(result_json, ensure_ascii=False, indent='\t'))
