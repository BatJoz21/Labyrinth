using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[CreateAssetMenu(fileName = "Scale Animation", menuName = "Custom Asset/Animation/Scale Animation")]
public class AnimationScale : BaseAnimation
{
    public override void Animate(Transform visual)
    {
        base.Animate(visual);

        visual.parent.DOScale(1.2f, base.duration).SetLoops(-1, LoopType.Yoyo);
    }
}
