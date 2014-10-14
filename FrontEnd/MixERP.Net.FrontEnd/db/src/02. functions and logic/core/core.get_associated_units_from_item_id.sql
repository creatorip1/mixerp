CREATE FUNCTION core.get_associated_units_from_item_id(integer)
RETURNS TABLE(unit_id integer, unit_code text, unit_name text)
AS
$$
DECLARE _unit_id integer;
BEGIN
    SELECT core.items.unit_id INTO _unit_id
    FROM core.items
    WHERE core.items.item_id=$1;

    RETURN QUERY
    SELECT ret.unit_id, ret.unit_code, ret.unit_name
    FROM core.get_associated_units(_unit_id) AS ret;

END
$$
LANGUAGE plpgsql;