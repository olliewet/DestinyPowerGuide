   M S B A M L   `   `   `  ����P  LDestiny2PowerLevelMax, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Destiny2PowerLevelMaxDestiny2PowerLevelMax  5   	   #    Destiny2PowerLevelMax.Rewards   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Destiny2PowerLevelMax     5   	     � WindowStartupLocation$  Manual=�5   	    � Left$	 500��5	   	   
 � Top$	 300��6    � 
ResizeMode$ NoResize=�5
   	    � WindowStyle$
 None=�5   	    � Title$ Rewards��5   	   $	��450��6   $	��800��6&   .��5      � ��5   
   �� 5       �� ImageSource$W QC:\Users\Ollie\Desktop\Work\Year 3\Destiny2PowerLevelMax\Assets\wallpaperload.jpg��6    j� Stretch$ UniformToFill=�6y   .+�5   
   �� -   5         ��Name$
 Home��5      
������ $��0q�68   $
��Home��6L   $
��Left=�6[   $��	637,0,0,0q�6v   $	��Top=�6�   $��83��6�   $��42��6�   �� 5   
   -   5        	 ��Name$	 RewardInfo_TB��5      
������ $��0q�6E   $
��Left=�6Y   $	��316��6t   $��
100,81,0,0q�6�   $	��Top=�6�   $	��607��6�   .@�5      �� -   5        
 ��Name$
 Info_Header��5      $
��Info��6+   .��5      � 
������ .+�5      � ���#9da8a8$
��Left=�60   $	��236��6K   $��	10,10,0,0q�6X   $	��Top=�6k   $	��160��6�   .+�5      �� -   5        $
 Soft��5   !   ���#4cc7c7$��0q�6D   $��Soft Cap��6X   $
��Left=�6k   $��
10,184,0,0q�6�   $	��Top=�6�   $	��140��6�   $��42��6�   �� 5      -   5        $��softTB��5   "   $	��158��60   $��
10,10,10,0q�6=    �� TextWrapping$
 Wrap=�6Q   $!��Current Soft Cap
750 - 1000��6e   $	��Top=�6�   6�   5      � 5      ���#9da8a8$
��Left=�60   $	��236��6K   $��
220,11,0,0q�6X   $	��Top=�6l   $	��160��6�   .+�5      �� -   5        $ Power��5   "   ���#4cc7c7$��0q�6F   $��Powerful Cap��6Z   $
��Left=�6q   $��
10,184,0,0q�6�   $	��Top=�6�   $	��139��6�   $��42��6�   �� 5      -   5        $��powerTB��5   "   $
��Left=�61   $	��158��6L   $��	10,10,0,0q�6Y   $
 Wrap=�6l   $&�� Current PowerFul Cap
1000 - 1050��6�   $	��Top=�6�   $	��139��6�   6�   5      � 5      ���#9da8a8$
��Left=�60   $	��236��6K   $��
422,10,0,0q�6X   $	��Top=�6l   $	��160��6�   .+�5       �� -   5        $
 Pinn��5    !   ���#4cc7c7$��0q�6D   $��Pinnacle Cap��6X   $
��Left=�6o   $��
10,184,0,0q�6�   $	��Top=�6�   $	��140��6�   $��42��6�   �� 5!      -	   5        $��pinnTB��5!   "   $
��Left=�60   $	��158��6K   $��	10,10,0,0q�6X   $
 Wrap=�6k   $&�� Current Pinnacle Cap
1050 - 1060��6   $	��Top=�6�   $	��140��6�   6�   5"      5$      5%      �� 5&      -
   5        $
 SoftCap_Header��5&      $��SoftCap��6.   .��5(      � 
������ $��	0,0,0,-30q�60    � ColumnDefinitions 5)      �� 5*      $	��34* �6+   �� 5+      $��2* �6+   �� 5,      $
��165* �6+   .+�5/      �� -   5        $��
softinfoTB��5/      $	��215��60   $��
10,10,19,0q�6=   $
 Wrap=�6Q   $����Current Soft Cap
- World Drops 
- Engrams 
- Vendors (Tokens Vanguard, Cruicble) (Gunsmith For Weapons) 
- Activity Completion 
- Matchmade Activity
- Year 1 and 2 Raids however removing in September 
- Shattered Throne 
- Public Events ��6e   $	��Top=�6�  $��3��6�  �� 50      -   5        $ BackSoft��50      
������ $��0q�6H   $
��Back��6\   $
��Left=�6k   $��376,235,0,0q�6�   $	��Top=�6�   $	��100��6�   $��28��6�   $��2��6�   51      53      �� 54      -   5        $
 PowerCap_Header��54      $��Powerful Cap��6/   .��55      � 
������ .+�56      �� -   5        $��PowerinfoTB��56      $	��215��61   $��
10,10,19,0q�6>   $
 Wrap=�6R   $����Powerful Cap (Weekly Completion)  
- Flashpoint 
- Nightmare Hunts 
- Nightfall - Three Ordeal Completions 
- Eight Bounties ( Strikes , Gambit , Crucible ) 
- Prime Engrams 
- Crucible valor and Gambit infamy rank-ups 
- Crucible glory
- Lunar Recall weekly mission on the Moon
- Luna's Calling weekly quest from Eris Morn
- Hawthorne's weekly clan exp reward
- Pit of Heresy dungeon – The Necropolis and Chamber of Suffering encounters net you powerful drops.
The Prophecy dungeon – The first two encounters (Phalanx Echo and Hexahedron) provide powerful gear.��6f   $	��Top=�6  $��3��6H  �� 57      -   5        $ 	BackPower��57      
������ $��0q�6I   $
��Back��6]   $
��Left=�6l   $��484,238,0,0q�6�   $	��Top=�6�   $	��100��6�   $��42��6�   58      59      �� 5:      -   5        $
 PinnCap_Header��5:      $��Pinnacle Cap��6.   .��5;      � 
������ $��	0,0,0,-18q�60    5<      �� 5=      $
��145* �6+   �� 5>      $
��458* �6+   .+�5@      �� -   5        $��
PinninfoTB��5@      $	��249��60   $��
10,10,19,0q�6=   $
 Wrap=�6Q   $����+1 
- 3 Strikes 
- 3 Gambit Matches
- 4 Crucible Matches 
- Clan Engram 

+2
Pit of Heresy Boss Kill ( Armour Piece ) 
Garden of Salvation (+2 Per Encounter ) 
100k Nightfall 
1080 Nightmare Hunt 
Iron Banner Bounties 
7th Trials Win and Flawless 
Interference Weekly Quest 
Prophecy Dungeon Boss Kill ��6e   $	��Top=�6  $��2��6U  �� 5A      -   5        $
 Back��5A      
������ $��0q�6D   $
��Back��6X   $
��Left=�6g   $��348,272,0,0q�6�   $	��Top=�6�   $	��100��6�   $��26��6�   $��1��6�   5B      5C      5D      �� 5E   
   -   5        $ Minus��5E      $��-��6    $��30(�6,   
������ $��0q�6S   
���   �$
��Bold"�6z   $��
720,-8,0,0q�6�   $	��Top=�6�   $��50��6�   $
��Left=�6�   $��32��6�   �� 5F   
   -   5        $ Close��5F      $��X��6    
������ $��0q�6E   
���   �$
��Bold"�6l   $��	752,0,0,0q�6~   $	��Top=�6�   $��42��6�   $
��Left=�6�   $��32��6�   5G      5H      