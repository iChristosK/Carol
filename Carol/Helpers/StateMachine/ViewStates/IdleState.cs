﻿using System;
using AppKit;
using Carol.Views;

namespace Carol.Helpers.StateMachine.ViewStates
{
    public class IdleState : StatefulViewController
    {
        public override void Enter(ViewStateMachine stateMachine)
        {
            ContainerView = LoadNib.LoadViewFromNib<IdleView>("IdleView", CurrentDelegate.controller.View);
            ContainerView.Frame = CurrentDelegate.controller.View.Bounds;
            CurrentDelegate.controller.View.AddSubview(ContainerView, NSWindowOrderingMode.Above, CurrentDelegate.controller.View);
        }

        public override void Exit(ViewStateMachine stateMachine)
        {
            ContainerView.RemoveFromSuperview();
        }
    }
}
