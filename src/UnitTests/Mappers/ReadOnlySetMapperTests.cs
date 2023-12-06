namespace AutoMapper.UnitTests.Mappers.ReadOnlySetMapper;

public class When_mapping_interface_to_interface_readonly_set : AutoMapperSpecBase
{
    public class Source
    {
        public IReadOnlySet<int> Values { get; set; }
    }

    public class Destination
    {
        public IReadOnlySet<int> Values { get; set; }
    }

    protected override MapperConfiguration CreateConfiguration() => new(config =>
    {
        config.CreateMap<Source, Destination>();
    });

    [Fact]
    public void Should_map_readonly_values()
    {
        var values = new HashSet<int>
        {
            1,
            2,
            3,
            4,
        };
        var source = new Source
        {
            Values = values
        };

        var dest = Mapper.Map<Destination>(source);

        dest.Values.ShouldBe(values);
    }
}

public class When_mapping_interface_to_concrete_readonly_set : AutoMapperSpecBase
{
    public class Source
    {
        public IReadOnlySet<int> Values { get; set; }
    }

    public class Destination
    {
        public HashSet<int> Values { get; set; }
    }

    protected override MapperConfiguration CreateConfiguration() => new(config =>
    {
        config.CreateMap<Source, Destination>();
    });

    [Fact]
    public void Should_map_readonly_values()
    {
        var values = new HashSet<int>
        {
            1,
            2,
            3,
            4,
        };
        var source = new Source
        {
            Values = values
        };

        var dest = Mapper.Map<Destination>(source);

        dest.Values.ShouldBe(values);
    }
}