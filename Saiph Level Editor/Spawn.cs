namespace Saiph_Level_Editor {
	public class Spawn {
		public decimal X { get; set; }
		public decimal Y { get; set; }
		public decimal Wait { get; set; }
		public decimal Interval { get; set; }
		public decimal EnemyType { get; set; }
		public decimal Amount { get; set; }

		public override string ToString() {
			return $"Spawn Enemy {EnemyType} at ({X}, {Y})";
		}

		public Spawn(decimal _x = 0, decimal _y = 0, decimal _wait = 0, decimal _interval = 0, decimal _enemyType = 0, decimal _amount = 0) {
			X = _x;
			Y = _y;
			Wait = _wait;
			Interval = _interval;
			EnemyType = _enemyType;
			Amount = _amount;
		}
	}
}
