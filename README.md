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

#### Coroutine Utility
**`Start(routine)`** : 코루틴을 실행하고 핸들을 반환합니다.<br>
**`Stop(coroutine)`** : 해당 코루틴을 정지합니다.<br>
**`StopAll()`** : 실행 중인 모든 코루틴을 정지합니다.<br>
**`Delay(seconds, action)`** : seconds 초 후 action을 실행합니다.<br>
**`DelayFrame(frameCount, action)`** : frameCount 프레임 후 action을 실행합니다.<br>
**`NextFrame(action)`** : 다음 프레임에 action을 실행합니다.<br>
**`EndOfFrame(action)`** : 이번 프레임의 렌더링이 끝난 직후 action을 실행합니다.<br>
**`WaitUntil(predicate, action)`** : predicate가 true가 될 때까지 대기 후 action을 실행합니다.<br>
**`Repeat(interval, action, count)`** : interval 초마다 action을 반복 실행합니다. count가 -1이면 무한 반복합니다.<br>

<br>
