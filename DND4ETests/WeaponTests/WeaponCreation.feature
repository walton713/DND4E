Feature: WeaponCreation
	As a player
	I want to have weapons
	So that I can vanquish my foes

Scenario Outline: OneHandNoRangeOneGroupNoProperties
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And no range
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group>"
	And no properties
	And is One-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon | prof | dienum | diesize | cost | weight | group       | quantity | melee |
	| Club   | 2    | 1      | 6       | 1    | 3      | Mace        | 1        | true  |
	| Rapier | 3    | 1      | 8       | 25   | 2      | Light Blade | 1        | true  |

Scenario Outline: OneHandWithRangeOneGroupTwoProperties
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And a short range of <short>
	And a long range of <long>
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group>"
	And the "<prop1>" property
	And the "<prop2>" property
	And is One-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon          | prof | dienum | diesize | short | long | cost | weight | group       | prop1     | prop2        | quantity | melee |
	| Dagger          | 3    | 1      | 4       | 5     | 10   | 1    | 1      | Light Blade | Off-Hand  | Light Thrown | 1        | true  |
	| Handaxe         | 2    | 1      | 6       | 5     | 10   | 5    | 3      | Axe         | Off-Hand  | Heavy Thrown | 1        | true  |
	| Throwing Hammer | 2    | 1      | 6       | 5     | 10   | 5    | 2      | Hammer      | Off-Hand  | Heavy Thrown | 1        | true  |
	| Trident         | 2    | 1      | 8       | 3     | 6    | 10   | 4      | Spear       | Versatile | Heavy Thrown | 1        | true  |
	| Tratnyr         | 2    | 1      | 8       | 10    | 20   | 10   | 5      | Spear       | Versatile | Heavy Thrown | 1        | true  |

Scenario Outline: OneHandWithRangeOneGroupOneProperty
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And a short range of <short>
	And a long range of <long>
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group>"
	And the "<prop>" property
	And is One-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon        | prof | dienum | diesize | short | long | cost | weight | group       | prop         | quantity | melee |
	| Javelin       | 2    | 1      | 6       | 10    | 20   | 5    | 2      | Spear       | Heavy Thrown | 1        | true  |
	| Hand Crossbow | 2    | 1      | 6       | 10    | 20   | 25   | 2      | Crossbow    | Load Free    | 1        | false |
	| Sling         | 2    | 1      | 6       | 10    | 20   | 1    | 0      | Sling       | Load Free    | 1        | false |
	| Shuriken      | 3    | 1      | 4       | 6     | 12   | 1    | 0.5    | Light Blade | Light Thrown | 5        | false |

Scenario Outline: OneHandNoRangeOneGroupOneProperty
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And no range
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group>"
	And the "<prop>" property
	And is One-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon              | prof | dienum | diesize | cost | weight | group       | prop      | quantity | melee |
	| Mace                | 2    | 1      | 8       | 5    | 6      | Mace        | Versatile | 1        | true  |
	| Sickle              | 2    | 1      | 6       | 2    | 2      | Light Blade | Off-Hand  | 1        | true  |
	| Spear               | 2    | 1      | 8       | 5    | 6      | Spear       | Versatile | 1        | true  |
	| Battleaxe           | 2    | 1      | 10      | 15   | 6      | Axe         | Versatile | 1        | true  |
	| Flail               | 2    | 1      | 10      | 10   | 5      | Flail       | Versatile | 1        | true  |
	| Longsword           | 3    | 1      | 8       | 15   | 4      | Heavy Blade | Versatile | 1        | true  |
	| Scimitar            | 2    | 1      | 8       | 10   | 4      | Heavy Blade | High Crit | 1        | true  |
	| Short Sword         | 3    | 1      | 6       | 10   | 2      | Light Blade | Off-Hand  | 1        | true  |
	| Warhammer           | 2    | 1      | 10      | 15   | 5      | Hammer      | Versatile | 1        | true  |
	| Bastard Sword       | 3    | 1      | 10      | 30   | 6      | Heavy Blade | Versatile | 1        | true  |
	| Spiked Gauntlet     | 2    | 1      | 6       | 5    | 1      | Unarmed     | Off-Hand  | 1        | true  |
	| Broadsword          | 2    | 1      | 10      | 20   | 5      | Heavy Blade | Versatile | 1        | true  |
	| Scourge             | 2    | 1      | 8       | 3    | 2      | Flail       | Off-Hand  | 1        | true  |
	| Triple-Headed Flail | 3    | 1      | 10      | 15   | 6      | Flail       | Versatile | 1        | true  |

Scenario Outline: OneHandNoRangeOneGroupTwoProperties
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And no range
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group>"
	And the "<prop1>" property
	And the "<prop2>" property
	And is One-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon          | prof | dienum | diesize | cost | weight | group       | prop1     | prop2     | quantity | melee |
	| War Pick        | 2    | 1      | 8       | 15   | 6      | Pick        | High Crit | Versatile | 1        | true  |
	| Katar           | 3    | 1      | 6       | 3    | 1      | Light Blade | Off-Hand  | High Crit | 1        | true  |
	| Light War Pick  | 2    | 1      | 6       | 10   | 4      | Pick        | High Crit | Off-Hand  | 1        | true  |
	| Craghammer      | 2    | 1      | 10      | 20   | 6      | Hammer      | Brutal 2  | Versatile | 1        | true  |
	| Kukri           | 2    | 1      | 6       | 10   | 2      | Light Blade | Brutal 1  | Off-Hand  | 1        | true  |
	| Parrying Dagger | 2    | 1      | 4       | 5    | 1      | Light Blade | Defensive | Off-Hand  | 1        | true  |

Scenario Outline: OneHandNoRangeTwoGroupsTwoProperties
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And no range
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group1>"
	And a group of "<group2>"
	And the "<prop1>" property
	And the "<prop2>" property
	And is One-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon  | prof | dienum | diesize | cost | weight | group1 | group2      | prop1    | prop2     | quantity | melee |
	| Khopesh | 2    | 1      | 8       | 20   | 8      | Axe    | Heavy Blade | Brutal 1 | Versatile | 1        | true  |

Scenario Outline: TwoHandNoRangeOneGroupNoProperties
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And no range
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group>"
	And no properties
	And is Two-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples:
	| weapon       | prof | dienum | diesize | cost | weight | group       | quantity | melee |
	| Greatclub    | 2    | 2      | 4       | 1    | 10     | Mace        | 1        | true  |
	| Morningstar  | 2    | 1      | 10      | 10   | 8      | Mace        | 1        | true  |
	| Quarterstaff | 2    | 1      | 8       | 5    | 4      | Staff       | 1        | true  |
	| Scythe       | 2    | 2      | 4       | 5    | 10     | Heavy Blade | 1        | true  |
	| Greatsword   | 3    | 1      | 10      | 30   | 8      | Heavy Blade | 1        | true  |
	| Heavy Flail  | 2    | 2      | 6       | 25   | 10     | Flail       | 1        | true  |
	| Maul         | 2    | 2      | 6       | 30   | 12     | Hammer      | 1        | true  |

Scenario Outline: TwoHandNoRangeOneGroupOneProperty
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And no range
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group>"
	And the "<prop>" property
	And is Two-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon         | prof | dienum | diesize | cost | weight | group       | prop      | quantity | melee |
	| Falchion       | 3    | 2      | 4       | 25   | 7      | Heavy Blade | High Crit | 1        | true  |
	| Greataxe       | 2    | 1      | 12      | 30   | 12     | Axe         | High Crit | 1        | true  |
	| Spiked Chain   | 3    | 2      | 4       | 30   | 10     | Flail       | Reach     | 1        | true  |
	| Heavy War Pick | 2    | 1      | 12      | 20   | 8      | Pick        | High Crit | 1        | true  |

Scenario Outline: TwoHandNoRangeTwoGroupsOneProperty
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And no range
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group1>"
	And a group of "<group2>"
	And the "<prop>" property
	And is Two-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon    | prof | dienum | diesize | cost | weight | group1      | group2  | prop  | quantity | melee |
	| Glaive    | 2    | 2      | 4       | 25   | 10     | Heavy Blade | Polearm | Reach | 1        | true  |
	| Halberd   | 2    | 1      | 10      | 25   | 12     | Axe         | Polearm | Reach | 1        | true  |
	| Longspear | 2    | 1      | 10      | 10   | 9      | Spear       | Polearm | Reach | 1        | true  |

Scenario Outline: TwoHandWithRangeOneGroupOneProperty
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And a short range of <short>
	And a long range of <long>
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group>"
	And the "<prop>" property
	And is Two-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon   | prof | dienum | diesize | short | long | cost | weight | group    | prop       | quantity | melee |
	| Crossbow | 2    | 1      | 8       | 15    | 30   | 25   | 4      | Crossbow | Load Minor | 1        | false |
	| Longbow  | 2    | 1      | 10      | 20    | 40   | 30   | 3      | Bow      | Load Free  | 1        | false |

Scenario Outline: TwoHandWithRangeOneGroupTwoProperties
	Given I have a "<weapon>"
	Then it has the name "<weapon>"
	And a <prof> proficiency bonus
	And a die number of <dienum>
	And a die size of <diesize>
	And a short range of <short>
	And a long range of <long>
	And a cost of <cost>
	And a weight of <weight>
	And a group of "<group>"
	And the "<prop1>" property
	And the "<prop2>" property
	And is Two-Handed
	And a quantity of <quantity>
	And is "<melee>"

	Examples: 
	| weapon   | prof | dienum | diesize | short | long | cost | weight | group | prop1     | prop2 | quantity | melee |
	| Shortbow | 2    | 1      | 8       | 15    | 30   | 25   | 2      | Bow   | Load Free | Small | 1        | false |