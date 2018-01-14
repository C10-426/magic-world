﻿// ---------------------------------------------------------------------
// THIS FILE IS AUTO-GENERATED BY BEHAVIAC DESIGNER, SO PLEASE DON'T MODIFY IT BY YOURSELF!
// ---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace behaviac
{
	public class CompareValue_GameGeek_Character_CharacterType : ICompareValue<GameGeek.Character.CharacterType>
	{
		public override bool Equal(GameGeek.Character.CharacterType lhs, GameGeek.Character.CharacterType rhs)
		{
			return lhs == rhs;
		}
		public override bool NotEqual(GameGeek.Character.CharacterType lhs, GameGeek.Character.CharacterType rhs)
		{
			return lhs != rhs;
		}
		public override bool Greater(GameGeek.Character.CharacterType lhs, GameGeek.Character.CharacterType rhs)
		{
			return lhs > rhs;
		}
		public override bool GreaterEqual(GameGeek.Character.CharacterType lhs, GameGeek.Character.CharacterType rhs)
		{
			return lhs >= rhs;
		}
		public override bool Less(GameGeek.Character.CharacterType lhs, GameGeek.Character.CharacterType rhs)
		{
			return lhs < rhs;
		}
		public override bool LessEqual(GameGeek.Character.CharacterType lhs, GameGeek.Character.CharacterType rhs)
		{
			return lhs <= rhs;
		}
	}

	public class CompareValue_GameGeek_Character_GenderType : ICompareValue<GameGeek.Character.GenderType>
	{
		public override bool Equal(GameGeek.Character.GenderType lhs, GameGeek.Character.GenderType rhs)
		{
			return lhs == rhs;
		}
		public override bool NotEqual(GameGeek.Character.GenderType lhs, GameGeek.Character.GenderType rhs)
		{
			return lhs != rhs;
		}
		public override bool Greater(GameGeek.Character.GenderType lhs, GameGeek.Character.GenderType rhs)
		{
			return lhs > rhs;
		}
		public override bool GreaterEqual(GameGeek.Character.GenderType lhs, GameGeek.Character.GenderType rhs)
		{
			return lhs >= rhs;
		}
		public override bool Less(GameGeek.Character.GenderType lhs, GameGeek.Character.GenderType rhs)
		{
			return lhs < rhs;
		}
		public override bool LessEqual(GameGeek.Character.GenderType lhs, GameGeek.Character.GenderType rhs)
		{
			return lhs <= rhs;
		}
	}

	public class CompareValue_GameGeek_Character_SkillStatus : ICompareValue<GameGeek.Character.SkillStatus>
	{
		public override bool Equal(GameGeek.Character.SkillStatus lhs, GameGeek.Character.SkillStatus rhs)
		{
			return lhs == rhs;
		}
		public override bool NotEqual(GameGeek.Character.SkillStatus lhs, GameGeek.Character.SkillStatus rhs)
		{
			return lhs != rhs;
		}
		public override bool Greater(GameGeek.Character.SkillStatus lhs, GameGeek.Character.SkillStatus rhs)
		{
			return lhs > rhs;
		}
		public override bool GreaterEqual(GameGeek.Character.SkillStatus lhs, GameGeek.Character.SkillStatus rhs)
		{
			return lhs >= rhs;
		}
		public override bool Less(GameGeek.Character.SkillStatus lhs, GameGeek.Character.SkillStatus rhs)
		{
			return lhs < rhs;
		}
		public override bool LessEqual(GameGeek.Character.SkillStatus lhs, GameGeek.Character.SkillStatus rhs)
		{
			return lhs <= rhs;
		}
	}

	public class CompareValue_GameGeek_Character_SkillType : ICompareValue<GameGeek.Character.SkillType>
	{
		public override bool Equal(GameGeek.Character.SkillType lhs, GameGeek.Character.SkillType rhs)
		{
			return lhs == rhs;
		}
		public override bool NotEqual(GameGeek.Character.SkillType lhs, GameGeek.Character.SkillType rhs)
		{
			return lhs != rhs;
		}
		public override bool Greater(GameGeek.Character.SkillType lhs, GameGeek.Character.SkillType rhs)
		{
			return lhs > rhs;
		}
		public override bool GreaterEqual(GameGeek.Character.SkillType lhs, GameGeek.Character.SkillType rhs)
		{
			return lhs >= rhs;
		}
		public override bool Less(GameGeek.Character.SkillType lhs, GameGeek.Character.SkillType rhs)
		{
			return lhs < rhs;
		}
		public override bool LessEqual(GameGeek.Character.SkillType lhs, GameGeek.Character.SkillType rhs)
		{
			return lhs <= rhs;
		}
	}

	public class CompareValue_GameGeek_Character_PatrolStatus : ICompareValue<GameGeek.Character.PatrolStatus>
	{
		public override bool Equal(GameGeek.Character.PatrolStatus lhs, GameGeek.Character.PatrolStatus rhs)
		{
			return lhs == rhs;
		}
		public override bool NotEqual(GameGeek.Character.PatrolStatus lhs, GameGeek.Character.PatrolStatus rhs)
		{
			return lhs != rhs;
		}
		public override bool Greater(GameGeek.Character.PatrolStatus lhs, GameGeek.Character.PatrolStatus rhs)
		{
			return lhs > rhs;
		}
		public override bool GreaterEqual(GameGeek.Character.PatrolStatus lhs, GameGeek.Character.PatrolStatus rhs)
		{
			return lhs >= rhs;
		}
		public override bool Less(GameGeek.Character.PatrolStatus lhs, GameGeek.Character.PatrolStatus rhs)
		{
			return lhs < rhs;
		}
		public override bool LessEqual(GameGeek.Character.PatrolStatus lhs, GameGeek.Character.PatrolStatus rhs)
		{
			return lhs <= rhs;
		}
	}


	public class BehaviorLoaderImplement : BehaviorLoader
	{
		private class CMethod_behaviac_Agent_VectorAdd : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorAdd()
			{
			}

			public CMethod_behaviac_Agent_VectorAdd(CMethod_behaviac_Agent_VectorAdd rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorAdd(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorAdd((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorClear : CAgentMethodVoidBase
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorClear()
			{
			}

			public CMethod_behaviac_Agent_VectorClear(CMethod_behaviac_Agent_VectorClear rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorClear(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				behaviac.Agent.VectorClear((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorContains : CAgentMethodBase<bool>
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorContains()
			{
			}

			public CMethod_behaviac_Agent_VectorContains(CMethod_behaviac_Agent_VectorContains rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorContains(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				_returnValue.value = behaviac.Agent.VectorContains((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorLength : CAgentMethodBase<int>
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorLength()
			{
			}

			public CMethod_behaviac_Agent_VectorLength(CMethod_behaviac_Agent_VectorLength rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorLength(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				_returnValue.value = behaviac.Agent.VectorLength((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorRemove : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorRemove()
			{
			}

			public CMethod_behaviac_Agent_VectorRemove(CMethod_behaviac_Agent_VectorRemove rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorRemove(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorRemove((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}


		public override bool Load()
		{
			AgentMeta.TotalSignature = 2114511362;

			AgentMeta meta;

			// behaviac.Agent
			meta = new AgentMeta(24743406);
			AgentMeta._AgentMetas_[2436498804] = meta;
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { behaviac.Agent.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// GameGeek.Character.Character
			meta = new AgentMeta(277886623);
			AgentMeta._AgentMetas_[323206309] = meta;
			meta.RegisterMemberProperty(2590663027, new CMemberProperty<GameGeek.Character.CharacterType>("characterType", delegate(Agent self, GameGeek.Character.CharacterType value) { ((GameGeek.Character.Character)self).characterType = value; }, delegate(Agent self) { return ((GameGeek.Character.Character)self).characterType; }));
			meta.RegisterMemberProperty(1120310671, new CMemberProperty<GameGeek.Character.CharacterProperty>("property", delegate(Agent self, GameGeek.Character.CharacterProperty value) { ((GameGeek.Character.Character)self).property = value; }, delegate(Agent self) { return ((GameGeek.Character.Character)self).property; }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { GameGeek.Character.Character.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// GameGeek.Character.PatrolAgent
			meta = new AgentMeta(1347991743);
			AgentMeta._AgentMetas_[918100545] = meta;
			meta.RegisterMemberProperty(806793830, new CMemberProperty<float>("alertRadius", delegate(Agent self, float value) { ((GameGeek.Character.PatrolAgent)self).alertRadius = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).alertRadius; }));
			meta.RegisterMemberProperty(3865369402, new CMemberProperty<float>("attackRange", delegate(Agent self, float value) { ((GameGeek.Character.PatrolAgent)self).attackRange = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).attackRange; }));
			meta.RegisterMemberProperty(2590663027, new CMemberProperty<GameGeek.Character.CharacterType>("characterType", delegate(Agent self, GameGeek.Character.CharacterType value) { ((GameGeek.Character.PatrolAgent)self).characterType = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).characterType; }));
			meta.RegisterMemberProperty(3262503671, new CMemberProperty<float>("chaseRadius", delegate(Agent self, float value) { ((GameGeek.Character.PatrolAgent)self).chaseRadius = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).chaseRadius; }));
			meta.RegisterMemberProperty(1987130516, new CMemberProperty<GameGeek.Character.PatrolStatus>("currentStatus", delegate(Agent self, GameGeek.Character.PatrolStatus value) { ((GameGeek.Character.PatrolAgent)self).currentStatus = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).currentStatus; }));
			meta.RegisterMemberProperty(3279942741, new CMemberProperty<float>("defendRadius", delegate(Agent self, float value) { ((GameGeek.Character.PatrolAgent)self).defendRadius = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).defendRadius; }));
			meta.RegisterMemberProperty(1120310671, new CMemberProperty<GameGeek.Character.CharacterProperty>("property", delegate(Agent self, GameGeek.Character.CharacterProperty value) { ((GameGeek.Character.PatrolAgent)self).property = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).property; }));
			meta.RegisterMemberProperty(3338410675, new CMemberProperty<float>("runSpeed", delegate(Agent self, float value) { ((GameGeek.Character.PatrolAgent)self).runSpeed = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).runSpeed; }));
			meta.RegisterMemberProperty(629020623, new CMemberProperty<float>("turnSpeed", delegate(Agent self, float value) { ((GameGeek.Character.PatrolAgent)self).turnSpeed = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).turnSpeed; }));
			meta.RegisterMemberProperty(74232591, new CMemberProperty<float>("walkSpeed", delegate(Agent self, float value) { ((GameGeek.Character.PatrolAgent)self).walkSpeed = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).walkSpeed; }));
			meta.RegisterMemberProperty(2754881844, new CMemberProperty<float>("wanderRadius", delegate(Agent self, float value) { ((GameGeek.Character.PatrolAgent)self).wanderRadius = value; }, delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).wanderRadius; }));
			meta.RegisterMethod(3734861530, new CAgentMethod<GameGeek.Character.PatrolStatus>(delegate(Agent self) { return ((GameGeek.Character.PatrolAgent)self).CalculateNewPatrolState(); }));
			meta.RegisterMethod(3548264208, new CAgentMethodVoid(delegate(Agent self) { ((GameGeek.Character.PatrolAgent)self).Chase(); }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { GameGeek.Character.PatrolAgent.LogMessage(param0); }));
			meta.RegisterMethod(242676355, new CAgentMethodVoid(delegate(Agent self) { ((GameGeek.Character.PatrolAgent)self).ReturnBack(); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());
			meta.RegisterMethod(1870214581, new CAgentMethodVoid(delegate(Agent self) { ((GameGeek.Character.PatrolAgent)self).Wander(); }));

			// GameGeek.Character.CharacterPlayer
			meta = new AgentMeta(3493719388);
			AgentMeta._AgentMetas_[3282746670] = meta;
			meta.RegisterMemberProperty(2590663027, new CMemberProperty<GameGeek.Character.CharacterType>("characterType", delegate(Agent self, GameGeek.Character.CharacterType value) { ((GameGeek.Character.CharacterPlayer)self).characterType = value; }, delegate(Agent self) { return ((GameGeek.Character.CharacterPlayer)self).characterType; }));
			meta.RegisterMemberProperty(1120310671, new CMemberProperty<GameGeek.Character.CharacterProperty>("property", delegate(Agent self, GameGeek.Character.CharacterProperty value) { ((GameGeek.Character.CharacterPlayer)self).property = value; }, delegate(Agent self) { return ((GameGeek.Character.CharacterPlayer)self).property; }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { GameGeek.Character.CharacterPlayer.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// GameGeek.Character.CharacterMonster
			meta = new AgentMeta(750622309);
			AgentMeta._AgentMetas_[1488296520] = meta;
			meta.RegisterMemberProperty(2590663027, new CMemberProperty<GameGeek.Character.CharacterType>("characterType", delegate(Agent self, GameGeek.Character.CharacterType value) { ((GameGeek.Character.CharacterMonster)self).characterType = value; }, delegate(Agent self) { return ((GameGeek.Character.CharacterMonster)self).characterType; }));
			meta.RegisterMemberProperty(1120310671, new CMemberProperty<GameGeek.Character.CharacterProperty>("property", delegate(Agent self, GameGeek.Character.CharacterProperty value) { ((GameGeek.Character.CharacterMonster)self).property = value; }, delegate(Agent self) { return ((GameGeek.Character.CharacterMonster)self).property; }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { GameGeek.Character.CharacterMonster.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// GameGeek.Character.CharacterProperty
			meta = new AgentMeta(3787893997);
			AgentMeta._AgentMetas_[169441367] = meta;
			meta.RegisterMemberProperty(2156613728, new CMemberProperty<float>("damage", delegate(Agent self, float value) { ((GameGeek.Character.CharacterProperty)self).damage = value; }, delegate(Agent self) { return ((GameGeek.Character.CharacterProperty)self).damage; }));
			meta.RegisterMemberProperty(1722614615, new CMemberProperty<int>("defanse", delegate(Agent self, int value) { ((GameGeek.Character.CharacterProperty)self).defanse = value; }, delegate(Agent self) { return ((GameGeek.Character.CharacterProperty)self).defanse; }));
			meta.RegisterMemberProperty(2269881519, new CMemberProperty<int>("hp", delegate(Agent self, int value) { ((GameGeek.Character.CharacterProperty)self).hp = value; }, delegate(Agent self) { return ((GameGeek.Character.CharacterProperty)self).hp; }));
			meta.RegisterMemberProperty(3652407279, new CMemberProperty<int>("level", delegate(Agent self, int value) { ((GameGeek.Character.CharacterProperty)self).level = value; }, delegate(Agent self) { return ((GameGeek.Character.CharacterProperty)self).level; }));
			meta.RegisterMemberProperty(2172675652, new CMemberProperty<int>("mp", delegate(Agent self, int value) { ((GameGeek.Character.CharacterProperty)self).mp = value; }, delegate(Agent self) { return ((GameGeek.Character.CharacterProperty)self).mp; }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { GameGeek.Character.CharacterProperty.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// GameGeek.Character.PlayerCharacterProperty
			meta = new AgentMeta(3704673207);
			AgentMeta._AgentMetas_[3465726432] = meta;
			meta.RegisterMemberProperty(2156613728, new CMemberProperty<float>("damage", delegate(Agent self, float value) { ((GameGeek.Character.PlayerCharacterProperty)self).damage = value; }, delegate(Agent self) { return ((GameGeek.Character.PlayerCharacterProperty)self).damage; }));
			meta.RegisterMemberProperty(1722614615, new CMemberProperty<int>("defanse", delegate(Agent self, int value) { ((GameGeek.Character.PlayerCharacterProperty)self).defanse = value; }, delegate(Agent self) { return ((GameGeek.Character.PlayerCharacterProperty)self).defanse; }));
			meta.RegisterMemberProperty(1411659799, new CMemberProperty<int>("experience", delegate(Agent self, int value) { ((GameGeek.Character.PlayerCharacterProperty)self).experience = value; }, delegate(Agent self) { return ((GameGeek.Character.PlayerCharacterProperty)self).experience; }));
			meta.RegisterMemberProperty(1552667377, new CMemberProperty<GameGeek.Character.GenderType>("gender", delegate(Agent self, GameGeek.Character.GenderType value) { ((GameGeek.Character.PlayerCharacterProperty)self).gender = value; }, delegate(Agent self) { return ((GameGeek.Character.PlayerCharacterProperty)self).gender; }));
			meta.RegisterMemberProperty(2269881519, new CMemberProperty<int>("hp", delegate(Agent self, int value) { ((GameGeek.Character.PlayerCharacterProperty)self).hp = value; }, delegate(Agent self) { return ((GameGeek.Character.PlayerCharacterProperty)self).hp; }));
			meta.RegisterMemberProperty(3652407279, new CMemberProperty<int>("level", delegate(Agent self, int value) { ((GameGeek.Character.PlayerCharacterProperty)self).level = value; }, delegate(Agent self) { return ((GameGeek.Character.PlayerCharacterProperty)self).level; }));
			meta.RegisterMemberProperty(2172675652, new CMemberProperty<int>("mp", delegate(Agent self, int value) { ((GameGeek.Character.PlayerCharacterProperty)self).mp = value; }, delegate(Agent self) { return ((GameGeek.Character.PlayerCharacterProperty)self).mp; }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { GameGeek.Character.PlayerCharacterProperty.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// GameGeek.Character.MonsterAI
			meta = new AgentMeta(1136571889);
			AgentMeta._AgentMetas_[3967467671] = meta;
			meta.RegisterMemberProperty(2590663027, new CMemberProperty<GameGeek.Character.CharacterType>("characterType", delegate(Agent self, GameGeek.Character.CharacterType value) { ((GameGeek.Character.MonsterAI)self).characterType = value; }, delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).characterType; }));
			meta.RegisterMemberProperty(1120310671, new CMemberProperty<GameGeek.Character.CharacterProperty>("property", delegate(Agent self, GameGeek.Character.CharacterProperty value) { ((GameGeek.Character.MonsterAI)self).property = value; }, delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).property; }));
			meta.RegisterMethod(3127879122, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).Attack(); }));
			meta.RegisterMethod(3174353026, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).CanSeeObject(); }));
			meta.RegisterMethod(3802241497, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).GetCurrentHealth(); }));
			meta.RegisterMethod(2046154313, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).IsAlive(); }));
			meta.RegisterMethod(3078249914, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).IsDamaged(); }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { GameGeek.Character.MonsterAI.LogMessage(param0); }));
			meta.RegisterMethod(740963922, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).Patrol(); }));
			meta.RegisterMethod(1951296462, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).RotateTowards(); }));
			meta.RegisterMethod(2247017846, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).Seek(); }));
			meta.RegisterMethod(596500905, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).ShowAnimation(); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());
			meta.RegisterMethod(1870214581, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).Wander(); }));
			meta.RegisterMethod(1685750376, new CAgentMethod<behaviac.EBTStatus>(delegate(Agent self) { return ((GameGeek.Character.MonsterAI)self).WithinDistance(); }));

			AgentMeta.Register<behaviac.Agent>("behaviac.Agent");
			AgentMeta.Register<GameGeek.Character.Character>("GameGeek.Character.Character");
			AgentMeta.Register<GameGeek.Character.PatrolAgent>("GameGeek.Character.PatrolAgent");
			AgentMeta.Register<GameGeek.Character.CharacterPlayer>("GameGeek.Character.CharacterPlayer");
			AgentMeta.Register<GameGeek.Character.CharacterMonster>("GameGeek.Character.CharacterMonster");
			AgentMeta.Register<GameGeek.Character.CharacterProperty>("GameGeek.Character.CharacterProperty");
			AgentMeta.Register<GameGeek.Character.PlayerCharacterProperty>("GameGeek.Character.PlayerCharacterProperty");
			AgentMeta.Register<GameGeek.Character.MonsterAI>("GameGeek.Character.MonsterAI");
			AgentMeta.Register<GameGeek.Character.CharacterType>("GameGeek.Character.CharacterType");
			ComparerRegister.RegisterType<GameGeek.Character.CharacterType, CompareValue_GameGeek_Character_CharacterType>();
			AgentMeta.Register<GameGeek.Character.GenderType>("GameGeek.Character.GenderType");
			ComparerRegister.RegisterType<GameGeek.Character.GenderType, CompareValue_GameGeek_Character_GenderType>();
			AgentMeta.Register<GameGeek.Character.SkillStatus>("GameGeek.Character.SkillStatus");
			ComparerRegister.RegisterType<GameGeek.Character.SkillStatus, CompareValue_GameGeek_Character_SkillStatus>();
			AgentMeta.Register<GameGeek.Character.SkillType>("GameGeek.Character.SkillType");
			ComparerRegister.RegisterType<GameGeek.Character.SkillType, CompareValue_GameGeek_Character_SkillType>();
			AgentMeta.Register<GameGeek.Character.PatrolStatus>("GameGeek.Character.PatrolStatus");
			ComparerRegister.RegisterType<GameGeek.Character.PatrolStatus, CompareValue_GameGeek_Character_PatrolStatus>();
			return true;
		}

		public override bool UnLoad()
		{
			AgentMeta.UnRegister<behaviac.Agent>("behaviac.Agent");
			AgentMeta.UnRegister<GameGeek.Character.Character>("GameGeek.Character.Character");
			AgentMeta.UnRegister<GameGeek.Character.PatrolAgent>("GameGeek.Character.PatrolAgent");
			AgentMeta.UnRegister<GameGeek.Character.CharacterPlayer>("GameGeek.Character.CharacterPlayer");
			AgentMeta.UnRegister<GameGeek.Character.CharacterMonster>("GameGeek.Character.CharacterMonster");
			AgentMeta.UnRegister<GameGeek.Character.CharacterProperty>("GameGeek.Character.CharacterProperty");
			AgentMeta.UnRegister<GameGeek.Character.PlayerCharacterProperty>("GameGeek.Character.PlayerCharacterProperty");
			AgentMeta.UnRegister<GameGeek.Character.MonsterAI>("GameGeek.Character.MonsterAI");
			AgentMeta.UnRegister<GameGeek.Character.CharacterType>("GameGeek.Character.CharacterType");
			AgentMeta.UnRegister<GameGeek.Character.GenderType>("GameGeek.Character.GenderType");
			AgentMeta.UnRegister<GameGeek.Character.SkillStatus>("GameGeek.Character.SkillStatus");
			AgentMeta.UnRegister<GameGeek.Character.SkillType>("GameGeek.Character.SkillType");
			AgentMeta.UnRegister<GameGeek.Character.PatrolStatus>("GameGeek.Character.PatrolStatus");
			return true;
		}
	}
}
