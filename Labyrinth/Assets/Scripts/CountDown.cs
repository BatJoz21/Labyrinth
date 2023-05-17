using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CountDown : MonoBehaviour
{
    [SerializeField] int duration;

    public UnityEvent OnCountFinished = new UnityEvent();
    public UnityEvent<int> OnCount = new UnityEvent<int>();

    bool isCounting;
    Coroutine countCoroutine;

    public void StartCount()
    {
        if (isCounting == false)
        {
            //StopAllCoroutines();
            StopCoroutine(countCoroutine);
        }
        countCoroutine = StartCoroutine(CountCoroutine());
    }

    private IEnumerator CountCoroutine()
    {
        isCounting = true;
        for (int i=duration; i>=0; i--)
        {
            OnCount.Invoke(i);
            yield return new WaitForSecondsRealtime(1);
        }
        isCounting = false;
        OnCountFinished.Invoke();
    }

    /*
    public void StartCount()
    {
        if (isCounting == true)
        {
            return;
        }
        else
        {
            isCounting = true;

        }
        DOTween.Kill(this.transform);
        var seq = DOTween.Sequence();

        OnCount.Invoke(duration);
        for (int i = duration - 1; i >= 0; i--)
        {
            seq.Append(transform
                .DOMove(this.transform.position, 1)
                .SetUpdate(true)
                .OnComplete(()=>OnCount.Invoke(i)));
        }
        seq.Append(transform
            .DOMove(this.transform.position, 1))
            .SetUpdate(true)
            .OnComplete(() => {
                isCounting = false;
                OnCountFinished.Invoke();
            });
    }
    */
}
