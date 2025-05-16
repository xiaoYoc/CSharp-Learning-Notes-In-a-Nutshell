# 布局控件

`Grid`是网格布局，需要我们分配行与列。

StackPanel主要用于垂直(默认)或水平排列元素、在容器的可用尺寸内放置有限个元素，元素的
尺寸总和(长/高)不允许超过StackPanel的尺寸, 否则超出的部分不可见。

```xaml
<Grid ShowGridLines="True">
    <!--行定义-->
    <Grid.RowDefinitions>
        <RowDefinition Height="30"/>
        <RowDefinition Height="20"/>
        <RowDefinition/>
        <RowDefinition Height="20"/>
    </Grid.RowDefinitions>
    <!--StackPanel占据第一行-->
    <StackPanel Grid.Row="0" Orientation="Horizontal">
        <Button Height="20" Content="文件" Width="70" />
        <Button Height="20" Content="编辑" Width="70"/>
        <Button Height="20" Content="视图" Width="70"/>
        <Button Height="20" Content="项目" Width="70"/>
    </StackPanel>
    <StackPanel Grid.Row="1" Orientation="Horizontal">
        <Button Height="20" Content="文件" Width="30"/>
        <Button Height="20" Content="编辑" Width="30"/>
        <Button Height="20" Content="视图" Width="30"/>
        <Button Height="20" Content="项目" Width="30"/>
    </StackPanel>
    <!--第三行控件-->
    <Grid Grid.Row="2">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="50"/>
            <ColumnDefinition/>
        </Grid.ColumnDefinitions>
        <StackPanel Grid.Column="0">
            <Button  Content="0" Height="30"/>
            <Button  Content="1" Height="30"/>
            <Button  Content="2" Height="30"/>
        </StackPanel>
        
        <TextBox Grid.Column="1" TextWrapping="Wrap" />
    </Grid>
</Grid>
```

![image-20250515220041057](assets/image-20250515220041057.png)

```xaml
<Grid.RowDefinitions>
    <RowDefinition/>
    <RowDefinition/>
    <RowDefinition Height="30"/>
</Grid.RowDefinitions>
<Grid.ColumnDefinitions>
    <ColumnDefinition/>
    <ColumnDefinition/>
</Grid.ColumnDefinitions>
<Border Margin="3" Background="#f24f1c"/>
<Border Margin="3" Background="#7fba00" Grid.Column="1"/>
<Border Margin="3" Grid.Row="1" Background="#00a7f0"/>
<Border Margin="3" Grid.Row="1" Grid.Column="1" Background="#feb900"/>
<!--设置跨行-->
<TextBlock Grid.Row="2" Text="Microsoft" FontSize="20" HorizontalAlignment="Center"
           VerticalAlignment="Center" Grid.ColumnSpan="2"/>
```

