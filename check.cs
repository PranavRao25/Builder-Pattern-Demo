public class Director {
	public Builder builder;

	public Director(int t) {
		switch(t) {
			case 1 {
				builder = new VectorDatabaseBuilder();
				break;
			}

			case 2 {
				builder = new GraphDatabaseBuilder();
				break;
			}

			case 3 {
				builder = new NoSQLDatabaseBuilder();
				break;
			}

			case 4 {
				builder = new NetworkDatabaseBuilder();
				break;
			}

			case 5 {
				builder = new RelationalDatabaseBuilder();
				break;
			}
		}
	}

	public void construct() {
		builder.BuildSomething();
	}

	public Database GetResult() {
		return builder.GetResult();
	}
}

public interface Builder {
	virtual void BuildSomething();
	virtual Database GetResult();
}

public class Database { // Product
	private int _something;

	public void SetSomething(int SomeValue) {
		this._something = SomeValue;
	}

	public void DisplayInfo() {
		// print
		;
	}
}

public VectorDatabaseBuilder : Builder {
	private Database _database;

	public void BuildSomething() {
		_database.SetSomething(1);
	}

	public Product GetResult() {
		return _database;
	}
}

public GraphDatabaseBuilder : Builder {
	private Database _database;

	public void BuildSomething() {
		_database.SetSomething(1);
	}

	public Product GetResult() {
		return _database;
	}
}

public NoSQLDatabaseBuilder : Builder {
	private Database _database;

	public void BuildSomething() {
		_database.SetSomething(1);
	}

	public Product GetResult() {
		return _database;
	}
}

public NetworkDatabaseBuilder : Builder {
	private Database _database;

	public void BuildSomething() {
		_database.SetSomething(1);
	}

	public Product GetResult() {
		return _database;
	}
}

public RelationalDatabaseBuilder : Builder {
	private Database _database;

	public void BuildSomething() {
		_database.SetSomething(1);
	}

	public Product GetResult() {
		return _database;
	}
}

public class Client {
	public static void main() {
		// specify type of database required
		Director director = new Director(1);

		director.construct();
		Product product = director.GetResult();

		product.DisplayInfo();

		return 0;
	}
}