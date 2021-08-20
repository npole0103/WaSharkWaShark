# 와샥와샥 Washark-Washark

> 🦈 **와이어샤크 구현** 🦈

> **김민경 | 김수헌 | 서민재**

# 1주차

---

**주간 목표 : 각 개발에 필요한 기능들을 테스트 하는 주간**

1. **pcapng 파일 json으로 변환 확인**

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled.png)

→ tshark를 설치하고 파이썬 Import os를 통해 .pcapng 파일을 .json 확장자로 출력

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%201.png)

→ pcapng 파일이 json 형태로 잘 변환된 것을 확인

1. **Process 클래스 이용해서 .py 파일 StandardOutput C#에서 읽기 가능 확인**

🦈 만약 패킷 핵심 정보들만 추출해주는 .py 파일이 최종적으로 개발된다면, .py 파일의 아웃풋을 C#으로 받아서 ListView에 행 단위로 삽입해야 함

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%202.png)

→ 위와 같은 예시 .py 파일을 만들고 읽기가 가능한지 Process 클래스를 사용하여 테스트 해봄

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%203.png)

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%204.png)

→ 필요한 .py 아웃풋을 C#으로 받을 수 있는 것을 확인

1. **배열 형식의 중첩된 json 파일 읽기 가능 확인**

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%205.png)

→ 위와 같이 key 값이 ip인 형태의 json 형식에서 value 값이 배열 형태로 된 파일을 읽는 방법을 찾아봄

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%206.png)

→ 비슷한 형식의 .json 파일을 만들고 읽기가 가능한지 실행해 봄

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%207.png)

→ json 변수의 형태를 jObject가 아닌 jArray로 선언하고 코드를 작성하여 실행

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%208.png)

→ 값이 정상적으로 들어가는 것을 확인

1. **GUI 와샥와샥 Winform 프로토타입 구성**

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%209.png)

1. **Python에서 C#에 전달할 데이터 추출 테스트**

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2010.png)

→ json 파일을 읽어 원하는 데이터를 key:value 형태로 출력

# 2주차

---

**주간 목표: 핵심 기능 구현**

1. **특정 패킷을 선택하여 파일로 저장하는 기능 구현(C# Winform)**

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2011.png)

    OpenFileDialog와 SaveFileDialog를 만들고 각각에 대해 Json 파일을 기본으로 설정을 진행해주었습니다.

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2012.png)

    JsonFile 저장하는 함수의 골격 코드이고, 위 함수를 응용하여 다음과 같은 4가지 저장 기능을 구현했습니다.

    - ListView 전체 패킷 정보 저장
    - Follow Stream 저장
    - Raw Packet 저장
    - Json View 저장

    **1-1. ListView 패킷 정보 저장** 

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2013.png)

    [ListView.json](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/ListView.json)

    **1-2. Follow Stream 저장** 

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2014.png)

    [FollowStream.json](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/FollowStream.json)

    **1-3. Raw Packet 저장** 

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2015.png)

    [RawPacket.json](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/RawPacket.json)

    **1-4. Json View 저장** 

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2016.png)

    [JsonView.json](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/JsonView.json)

1. **Python에서 각 패킷의 Raw Packet과 Json View를 C#에 넘겨주는 코드 추가**

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2017.png)

→ 단순히 **result["JsonView"] = i** 와 같은 방식으로 넘겨줄 경우 C# string 길이 제한으로 인해 프로그램이 제대로 실행되지 않음. 따라서 각 패킷마다 txt파일을 생성해서 저장하는 방식으로 구현

1. **GUI에서 Raw Packet과 Json View를 보여줄 수 있도록 함**

    Packet Details Form은 다음과 같음.

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2018.png)

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2019.png)

    Raw Packet 혹은 Json View 버튼을 눌렀을 때 새로운 Packet Details Form을 Modaless 방식으로 표시한다.

2. F**ollow Stream 출력 부분 구현**

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2020.png)

    ListView에서 특정 패킷을 선택했을 때 발생하는 이벤트인 SelectedIndexChanged 이벤트를 등록하여, 해당 패킷의 대화 형식을 RichTextBox에 Append 하여 나타냄. 또한, 실제 와이어샤크에서 구현된 것처럼 대화형식을 **빨간색 / 파란색** 텍스트로 구분지어 출력.

1. **예외처리**

    5-1. 패킷이 없는 상태에서 전체 패킷 저장을 누르면 경고창 출력

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2021.png)

    5-2. 패킷이 없거나 선택되지 않은 상태에서 Follow Stream 저장을 누르면 경고창 출력

    5-3. 패킷이 없거나 선택되지 않은 상태에서 Raw Packet 버튼을 누르면 경고창 출력

    5-4. 패킷이 없거나 선택되지 않은 상태에서 Json View 버튼을 누르면 경고창 출력

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2022.png)

# 3주차

---

**주간 목표: 대화 형식 완성 및 GUI 개선**

1. **json 파일을 분석하여 도메인과 URI 추출**

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2023.png)

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2024.png)

→ 해당 패킷이 요청 패킷인지 응답 패킷인지 판단한 후 도메인 추출. 응답 패킷에는 도메인이 없기 때문에 tcp stream 값을 key로 하고 도메인을 value로 하는 임시 딕셔너리 temp_domain을 만들어 사용

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2025.png)

→ 패킷 종류에 따라 URI가 저장된 key가 다르기 때문에 역시 해당 패킷이 요청 패킷인지 응답 패킷인지 판단한 후 URI 추출

1. **follow stream 기능 구현**

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2026.png)

→ 각 패킷의 follow stream을 뽑아오기 위해 stream 값을 비교하여 해당 stream의 패킷의 data를 순서대로 출력함

1. **필터링 기능**

    CheckBox를 이용하여 원하는 정보만 볼 수 있도록 필터링 기능 추가

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2027.png)

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2028.png)

    CheckedChanged 이벤트를 등록하여 Checked 상태 변경시 해당 열 숨기기 기능

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2029.png)

2. **GUI 개선**

    **Hex View 개선**

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2030.png)

    가독성이 심히 떨어지는 기존 Raw Packet의 Hex View를 Hxd와 비슷하게 가공하여 개선.

    ![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2031.png)

**Progress Bar 추가**

패킷을 로드하기전 State 상태를 나타내며 ProgressBar 진행률이 0%

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2032.png)

모든 패킷을 전부 읽었을 때 Complete가 출력되고 ProgressBar가 꽉 채워짐.

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2033.png)

# 구현 체크리스트

---

- **최소 구현**
- [x]  tshark를 활용하여 pcapng를 json파일로 추출
- [x]  대화 형식 구현
- **중간 구현**
- [x]  파일로 패킷 정보 저장
- [x]  IP와 도메인 출력
- [x]  필터링 기능
- **최대 구현**
- [ ]  실시간 패킷 분석(scapy)

# 결과물

---

![Untitled](%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%E1%84%8B%E1%85%AA%E1%84%89%E1%85%A3%E1%86%A8%20Washark-Washark%209d6483e7ac2848d3bc078ebc9bc46ca8/Untitled%2034.png)

# Github

---

**[Github]** **깃허브 메인 페이지**

[GitHub - npole0103/WaSharkWaShark: WaSharkWaShark](https://github.com/npole0103/WaSharkWaShark)

**[Download]** **WaSharkWaShark_1.0_ver.zip**

[](https://github.com/npole0103/WaSharkWaShark/raw/main/WaSharkWaShark_1.0_ver.zip)