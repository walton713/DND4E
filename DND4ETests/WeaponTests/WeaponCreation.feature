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

	Examples: 
	| weapon | prof | dienum | diesize | cost | weight | group |
	| Club   | 2    | 1      | 6       | 1    | 3      | Mace  |

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

	Examples: 
	| weapon | prof | dienum | diesize | short | long | cost | weight | group       | prop1    | prop2        |
	| Dagger | 3    | 1      | 4       | 5     | 10   | 1    | 1      | Light Blade | Off-Hand | Light Thrown |

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

	Examples: 
	| weapon  | prof | dienum | diesize | short | long | cost | weight | group | prop         |
	| Javelin | 2    | 1      | 6       | 10    | 20   | 5    | 2      | Spear | Heavy Thrown |

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

	Examples: 
	| weapon | prof | dienum | diesize | cost | weight | group       | prop      |
	| Mace   | 2    | 1      | 8       | 5    | 6      | Mace        | Versatile |
	| Sickle | 2    | 1      | 6       | 2    | 2      | Light Blade | Off-Hand  |