﻿Feature: WeaponCreation
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

	Examples: 
	| weapon | prof | dienum | diesize | cost | weight | group | quantity |
	| Club   | 2    | 1      | 6       | 1    | 3      | Mace  | 1        |

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

	Examples: 
	| weapon          | prof | dienum | diesize | short | long | cost | weight | group       | prop1    | prop2        | quantity |
	| Dagger          | 3    | 1      | 4       | 5     | 10   | 1    | 1      | Light Blade | Off-Hand | Light Thrown | 1        |
	| Handaxe         | 2    | 1      | 6       | 5     | 10   | 5    | 3      | Axe         | Off-Hand | Heavy Thrown | 1        |
	| Throwing Hammer | 2    | 1      | 6       | 5     | 10   | 5    | 2      | Hammer      | Off-Hand | Heavy Thrown | 1        |

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

	Examples: 
	| weapon  | prof | dienum | diesize | short | long | cost | weight | group | prop         | quantity |
	| Javelin | 2    | 1      | 6       | 10    | 20   | 5    | 2      | Spear | Heavy Thrown | 1        |

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

	Examples: 
	| weapon      | prof | dienum | diesize | cost | weight | group       | prop      | quantity |
	| Mace        | 2    | 1      | 8       | 5    | 6      | Mace        | Versatile | 1        |
	| Sickle      | 2    | 1      | 6       | 2    | 2      | Light Blade | Off-Hand  | 1        |
	| Spear       | 2    | 1      | 8       | 5    | 6      | Spear       | Versatile | 1        |
	| Battleaxe   | 2    | 1      | 10      | 15   | 6      | Axe         | Versatile | 1        |
	| Flail       | 2    | 1      | 10      | 10   | 5      | Flail       | Versatile | 1        |
	| Longsword   | 3    | 1      | 8       | 15   | 4      | Heavy Blade | Versatile | 1        |
	| Scimitar    | 2    | 1      | 8       | 10   | 4      | Heavy Blade | High Crit | 1        |
	| Short Sword | 3    | 1      | 6       | 10   | 2      | Light Blade | Off-Hand  | 1        |
	| Warhammer   | 2    | 1      | 10      | 15   | 5      | Hammer      | Versatile | 1        |

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

	Examples: 
	| weapon   | prof | dienum | diesize | cost | weight | group | prop1     | prop2     | quantity |
	| War Pick | 2    | 1      | 8       | 15   | 6      | Pick  | High Crit | Versatile | 1        |

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

	Examples:
	| weapon       | prof | dienum | diesize | cost | weight | group       | quantity |
	| Greatclub    | 2    | 2      | 4       | 1    | 10     | Mace        | 1        |
	| Morningstar  | 2    | 1      | 10      | 10   | 8      | Mace        | 1        |
	| Quarterstaff | 2    | 1      | 8       | 5    | 4      | Staff       | 1        |
	| Scythe       | 2    | 2      | 4       | 5    | 10     | Heavy Blade | 1        |
	| Greatsword   | 3    | 1      | 10      | 30   | 8      | Heavy Blade | 1        |
	| Heavy Flail  | 2    | 2      | 6       | 25   | 10     | Flail       | 1        |
	| Maul         | 2    | 2      | 6       | 30   | 12     | Hammer      | 1        |

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

	Examples: 
	| weapon   | prof | dienum | diesize | cost | weight | group       | prop      | quantity |
	| Falchion | 3    | 2      | 4       | 25   | 7      | Heavy Blade | High Crit | 1        |
	| Greataxe | 2    | 1      | 12      | 30   | 12     | Axe         | High Crit | 1        |

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

	Examples: 
	| weapon    | prof | dienum | diesize | cost | weight | group1      | group2  | prop  | quantity |
	| Glaive    | 2    | 2      | 4       | 25   | 10     | Heavy Blade | Polearm | Reach | 1        |
	| Halberd   | 2    | 1      | 10      | 25   | 12     | Axe         | Polearm | Reach | 1        |
	| Longspear | 2    | 1      | 10      | 10   | 9      | Spear       | Polearm | Reach | 1        |