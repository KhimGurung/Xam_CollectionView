# Xam_CollectionView

Simple xamarin form applcation using collection view to display items.

Implement Command to remove items. ViewModel binding does not work for command in CollectionView because it has binding context of CollectionView.

So binding context for command is given seperately follows:

```c#
    <ImageButton Source="trash.png"
                 HeightRequest="20"
                 Margin="0, 0, 20, 0"
                 Command="{Binding Source={x:Reference ViewPage}, Path=BindingContext.DeleteProductCommand}"
                 CommandParameter="{Binding .}"/>
```

"ViewPage" is the name of the ContentPage.