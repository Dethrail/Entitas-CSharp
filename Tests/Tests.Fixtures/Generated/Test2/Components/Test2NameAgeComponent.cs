//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity {

    public NameAgeComponent nameAge { get { return (NameAgeComponent)GetComponent(Test2ComponentsLookup.NameAge); } }
    public bool hasNameAge { get { return HasComponent(Test2ComponentsLookup.NameAge); } }

    public void AddNameAge(string newName, int newAge) {
        var component = CreateComponent<NameAgeComponent>(Test2ComponentsLookup.NameAge);
        component.name = newName;
        component.age = newAge;
        AddComponent(Test2ComponentsLookup.NameAge, component);
    }

    public void ReplaceNameAge(string newName, int newAge) {
        var component = CreateComponent<NameAgeComponent>(Test2ComponentsLookup.NameAge);
        component.name = newName;
        component.age = newAge;
        ReplaceComponent(Test2ComponentsLookup.NameAge, component);
    }

    public void RemoveNameAge() {
        RemoveComponent(Test2ComponentsLookup.NameAge);
    }
}