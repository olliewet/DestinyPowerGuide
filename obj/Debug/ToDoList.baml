   M S B A M L   `   `   `  ����P  LDestiny2PowerLevelMax, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Destiny2PowerLevelMaxDestiny2PowerLevelMax  5   	   $    Destiny2PowerLevelMax.ToDoList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Destiny2PowerLevelMax     5   	   U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5   	     � Left$	  500��5	   	   
 � Top$	 300��6    � WindowStyle$
 None=�5
   	    � Title$ ToDoList��5   	   $	��450��6   $	��800��6'   .��5      � -   5         �Name$ ToGrid��5      ��5   
   �� 5       �� ImageSource$W QC:\Users\Ollie\Desktop\Work\Year 3\Destiny2PowerLevelMax\Assets\wallpaperload.jpg��6    j� Stretch$ UniformToFill=�6y   .+�5   
   �� -   5         ��Name$
 Home��5      
������ $��0q�68   $
��Home��6L   $
��Left=�6[   $��	619,0,0,0q�6v   $	��Top=�6�   $��94��6�   $��42��6�   �� 5   
   -   5        $ 	Calculate��5      $��0q�6$   
������ $
��Left=�6Q   $��351,362,0,0q�6l   $	��Top=�6�   $��82��6�   $��47��6�   .��5      �� "  WpfAnimatedGif.ImageBehavior   AnimatedSource$O IC:\Users\Ollie\Desktop\Work\Year 3\Destiny2PowerLevelMax\Assets\Ghost.gif��6   5      �� 5   
   -   5        	 ��Name$	 ToDoBox��5      $
��Left=�6#   $	��266��6>   $��
485,66,0,0q�6K   $	��Top=�6_   $	��228��6w   �� 5   
   -   5        
 ��Name$
 FlashPoint_CB��5      $��Weekly Flashpoint��6*   $
��Left=�6F   $��
21,115,0,0q�6a   $	��Top=�6u   �� 5   
   -   5        $
 Nmh_CB��5      $��Nightmare Hunt��6#   $
��Left=�6<   $��
21,135,0,0q�6W   $	��Top=�6k   �� 5   
   -   5        $
 Nightfall_CB��5      $��Nightfall Ordeal��6)   $
��Left=�6D   $��
21,155,0,0q�6_   $	��Top=�6s   �� 5   
   -   5        $
 StrikesBounties_CB��5      $��Strike Bounties��6/   $
��Left=�6I   $��
21,175,0,0q�6d   $	��Top=�6x   �� 5   
   -	   5        $
 CrucibleBounties_CB��5      $��Crucible Bounties��60   $
��Left=�6L   $��
21,195,0,0q�6g   $	��Top=�6{   �� 5   
   -
   5        $
 GambitBounties_CB��5      $��Gambit Bounties��6.   $
��Left=�6H   $��
21,215,0,0q�6c   $	��Top=�6w   �� 5   
   -   5        $
 
strikes_CB��5      $��	3 Strikes��6'   $
��Left=�6;   $��160,115,0,0q�6V   $	��Top=�6k   �� 5   
   -   5        $
 	gambit_CB��5      $��3 Gambit Matches��6&   $
��Left=�6A   $��160,135,0,0q�6\   $	��Top=�6q   �� 5   
   -   5        $
 crucible_CB��5      $��4 Crucible Matches��6(   $
��Left=�6E   $��160,155,0,0q�6`   $	��Top=�6u   �� 5   
   -   5        $
 clan_engram��5      $��Clan Engram��6(   $
��Left=�6>   $��160,175,0,0q�6Y   $	��Top=�6n   �� 5    
   -   5        $
 
PitBoss_cb��5       $��Pit dungeon Boss Kill��6'   $
��Left=�6G   $��160,195,0,0q�6b   $	��Top=�6w   �� 5!   
   -   5        $
 Raid_Graden��5!      $��Garden of salvation��6(   $
��Left=�6F   $��160,215,0,0q�6a   $	��Top=�6v   �� 5"   
   -   5        $ Minus��5"      $��-��6    $��30(�6,   
������ $��0q�6S   
���   �$
��Bold"�6z   $��
720,-8,0,0q�6�   $	��Top=�6�   $��50��6�   $
��Left=�6�   $��32��6�   �� 5#   
   -   5         ��Name$ Powerful_lb��5#      $��Powerful Rewards��6%   $
��Left=�6@   $��	21,84,0,0q�6[   $	��Top=�6n   �� 5$   
   -   5        $ Pinnacles_lb��5$      $��Pinnacles Rewards��6&   $
��Left=�6B   $��
160,84,0,0q�6]   $	��Top=�6q   �� 5%   
   -   5        $ todolist_lb��5%      $��
To Do List��6%   $
��Left=�6:   $��
485,40,0,0q�6U   $	��Top=�6i   �� 5&   
   -   5        $ Time_lb��5&      $��12(�6!   $�� ��6/   $
��Left=�6:   $��485,337,0,0q�6U   $	��Top=�6j   $	��258��6�   $��44��6�   �� 5'   
   -   5        $ Close��5'      $��X��6    
������ $��0q�6E   
���   �$
��Bold"�6l   $��	750,0,0,0q�6~   $	��Top=�6�   $��42��6�   $
��Left=�6�   $��32��6�   5(      5)      