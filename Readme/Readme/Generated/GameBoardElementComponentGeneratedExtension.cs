//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;
using Entitas.Api;

public partial class GameEntity : Entity {

    static readonly GameBoardElementComponent gameBoardElementComponent = new GameBoardElementComponent();

    public bool isGameBoardElement {
        get { return HasComponent(ComponentIds.GameBoardElement); }
        set {
            if(value != isGameBoardElement) {
                if(value) {
                    AddComponent(ComponentIds.GameBoardElement, gameBoardElementComponent);
                } else {
                    RemoveComponent(ComponentIds.GameBoardElement);
                }
            }
        }
    }
}

public partial class GameMatcher {

    static IMatcher<GameEntity> _matcherGameBoardElement;

    public static IMatcher<GameEntity> GameBoardElement {
        get {
            if(_matcherGameBoardElement == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(ComponentIds.GameBoardElement);
                matcher.componentNames = ComponentIds.componentNames;
                _matcherGameBoardElement = matcher;
            }

            return _matcherGameBoardElement;
        }
    }
}
