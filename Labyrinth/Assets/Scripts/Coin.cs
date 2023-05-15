using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] Transform visual;
    [SerializeField] CoinData coinData;
    [SerializeField] BaseAnimation baseAnimation;

    public int Value { get => coinData.value; }

    private void Start()
    {
        visual.GetComponent<Renderer>().material = coinData.material;
        //baseAnimation.Animate(visual);
        Animate();
    }

    public void Animate()
    {
        var seq = DOTween.Sequence();
        seq.Append(visual.DOLocalRotate(new Vector3(visual.eulerAngles.x, 180, 0), 0.5f));
        seq.Append(visual.DOLocalRotate(new Vector3(visual.eulerAngles.x, 360, 0), 0.5f));
        seq.SetLoops(-1);
    }
}
