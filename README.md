# Utils
범용 유틸리티 함수 모음입니다. <br>

<br>
<br>
<br>

## 📖API

#### Bit Util
**`Has(current, flag)`** : 현재 비트 상태에 해당 flag가 포함되어 있는지 확인합니다.<br>
**`Any(current, flag)`** : 현재 비트 상태에 해당 flag가 하나라도 겹치는지 확인합니다.<br>
**`IsNone(current)`** : 현재 비트 상태가 비어있는지 확인합니다 (0인지 체크).<br>
**`IsSingle(current)`** : 현재 비트 상태가 하나의 flag만 가지고 있는지 확인합니다.<br>
**`Add(current, flag)`** : 현재 비트 상태에 flag를 추가합니다.<br>
**`Remove(current, flag)`** : 현재 비트 상태에서 flag를 제거합니다.<br>
**`Toggle(current, flag)`** : 현재 비트 상태에서 flag를 토글합니다.<br>
**`Combine(flags[])`** : 여러 개의 flag를 하나의 bit mask로 합칩니다.<br>
**`Flag(index)`** : index 값을 bit flag (1 << index)로 변환합니다.<br>
**`Count(current)`** : 현재 켜져 있는 bit의 개수를 반환합니다.<br>

<br>

#### DebugUtil
**`Log`** : 에디터 전용 Debug.Log <br>
**`LogWarning`** : 에디터 전용 Debug.LogWarning <br>
**`LogError`** : 에디터 전용 Debug.LogError <br>
**`LogException`** : 에디터 전용 Debug.LogException <br>

<br>
